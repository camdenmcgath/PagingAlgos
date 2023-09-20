using System.Numerics;
using System.Security.Cryptography;

namespace PagingAlgos
{
    public partial class Form1 : Form
    {
        List<int> stream;
        int pageFaults;
        List<Iteration> iterations;
        List<int> printList;
        public Form1()
        {
            InitializeComponent();
            stream = new List<int> {1, 2, 3, 2, 1, 5, 2, 1, 6, 2, 5, 6, 3, 1, 3, 6, 1, 2, 4, 3 };
            pageFaults = 0;
            iterations = new List<Iteration>();
            printList = new List<int>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            statlblPageFaultCount.Text = "Select a paging algorithm!";
        }

        private void FIFO()
        {
            HashSet<int> pageSet = new HashSet<int>();
            Queue<int> pageOrder = new Queue<int>(new[] { -1, -1, -1});
            foreach (int request in stream)
            {
                if (!pageSet.Contains(request))
                {
                    pageFaults++;
                    if (pageSet.Count >= 3)
                    {
                        pageSet.Remove(pageOrder.First());

                    }
                    pageOrder.Dequeue();
                    pageOrder.Enqueue(request);
                    pageSet.Add(request);

                }
                printList = new List<int>(pageOrder);
                iterations.Add( new Iteration(
                    request, printList.ElementAt(0), printList.ElementAt(1), printList.ElementAt(2), pageFaults));    
            }
            sourceData();
        }

        private void Unicorn()
        {
            List<int> pageList = new List<int> { -1, -1, -1 };
            int count = 0;
            int prev = 0;
            int furthest = 0;
            int j = 0;
            for (int i = 0; i < stream.Count; i++)
            {
                int request = stream[i];
                if (!pageList.Contains(request))
                {
                    pageFaults++;
                    if (pageList[0] != -1)
                    {
                        prev = 0;
                        furthest = 0;
                        foreach (int el in pageList)
                        {
                            j = i;
                            count = 0;
                            while (j < stream.Count && stream[j] != el)
                            {
                                count++;
                                j++;
                            }
                            if (count > prev)
                            {
                                prev = count;
                                furthest = el;
                            }
                        }
                        pageList[pageList.IndexOf(furthest)] = request;
                    }
                    else
                    {
                        pageList.RemoveAt(0);
                        pageList.Add(request);
                    }
                }
                printList = new List<int>(pageList);
                iterations.Add(new Iteration(
                request, printList.ElementAt(0), printList.ElementAt(1), printList.ElementAt(2), pageFaults));
            }
            sourceData();
        }

        private void LRU()
        {
            Dictionary<int, int> pageDict = new Dictionary<int, int>();
            int toRemove = 0;
            int maxVal = 0;    
            foreach (int request in stream)
            {
                if (pageDict.ContainsKey(request))
                {
                    foreach (var el in pageDict)
                    {
                        if (el.Key != request)
                        {
                            pageDict[el.Key] = el.Value + 1;
                        }

                    }
                    pageDict[request] = 0;
                }
                else
                {
                    pageFaults++;
                    if (pageDict.Count >= 3)
                    {
                        toRemove = 0;
                        maxVal = 0;
                        foreach (var el in pageDict)
                        {
                            if (el.Value > maxVal)
                            {
                                toRemove = el.Key;
                                maxVal = el.Value;
                            }
                            pageDict[el.Key] = el.Value + 1;
                        }
                        pageDict.Remove(toRemove);
                    }
                    pageDict.Add(request, 0);
                }
                printList = new List<int>(pageDict.Keys.ToList());
                while (printList.Count < 3)
                {
                    printList.Insert(0, -1);
                }
                iterations.Add(new Iteration(
                request, printList.ElementAt(0), printList.ElementAt(1), printList.ElementAt(2), pageFaults));
            }
            sourceData();
        }

        private void LFU()
        {
            Dictionary<int, int> pageDict = new Dictionary<int, int>();
            HashSet<int> pageSet = new HashSet<int>();
            int toRemove = 0;
            int min = 0;
            foreach (int request in stream)
            {
                if (!pageDict.ContainsKey(request))
                {
                    pageDict.Add(request, 1);
                }
                else
                {
                    pageDict[request] = pageDict[request] + 1;
                }
                if (!pageSet.Contains(request))
                {
                    pageFaults++;
                    if (pageSet.Count == 3 )
                    {
                        toRemove = 0;
                        min = int.MaxValue;
                        foreach (int el in pageSet)
                        {
                            if (pageDict[el] < min)
                            {
                                min = pageDict[el];
                                toRemove = el;
                            }
                        }
                        pageSet.Remove(toRemove);
                    }
                    pageSet.Add(request);
                }
                printList = new List<int>(pageSet);
                while (printList.Count < 3)
                {
                    printList.Insert(0, -1);
                }
                iterations.Add(new Iteration(
                request, printList.ElementAt(0), printList.ElementAt(1), printList.ElementAt(2), pageFaults));
            }
            sourceData();
        }

        private void sourceData()
        {
            var source = new BindingSource();
            source.DataSource = iterations;
            dgvResults.DataSource = source;
            statlblPageFaultCount.Text = "Total page faults: " + pageFaults.ToString();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            pageFaults = 0;
            iterations.Clear();
            printList.Clear();
            if (btnFIFO.Checked)
            {
                FIFO();
            }
            else if (btnOptimal.Checked)
            {
                Unicorn();
            }
            else if (btnLRU.Checked)
            {
                LRU();
            }
            else if (btnLFU.Checked)
            {
                LFU();
            }
        }
    }
    class Iteration
    {
        public string request { get; set; }
        public string page1 { get; set; }  
        public string page2 { get; set; }
        public string page3 { get; set; }
        public string faultCount { get; set; }
        public Iteration(int req, int p1, int p2, int p3, int pfc)
        {
            request = req.ToString();
            page1 = p1.ToString();
            page2 = p2.ToString();
            page3 = p3.ToString();
            faultCount = pfc.ToString();
        }

    }

}