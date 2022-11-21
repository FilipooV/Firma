namespace Firma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class myNode
        {
            public string rodzic;
            public string nazwa;

            public myNode(string rodzic, string nazwa)
            {
                this.rodzic = rodzic;
                this.nazwa = nazwa;
            }
        }
        private void DodajDoListy(TreeNode node, ref List<myNode> lista)
        {
            if (node == null)
                return;
            string r, n;
            if (node.Parent == null)
                r = "Brak";
            else
                r = node.Parent.Text;
            n = node.Text;

            lista.Add(new myNode(r, n));
            if(node.NextNode != null)
                DodajDoListy(node.NextNode, ref lista);
            if (node.GetNodeCount(true) > 0)
                DodajDoListy(node.FirstNode.NextNode, ref lista);
        }
        private void ZapisDoPliku()
        {
            List<myNode> lista = new List<myNode>();
            DodajDoListy(treeView1.Nodes[0], ref lista);
            if (lista.Count == 0)
                return;

            string text = "";
            foreach (myNode elem in lista)
            {
                text += elem.nazwa + " " + elem.rodzic + "\n";
                File.WriteAllText("firma.txt", text);
            }
        }
        private void DodajGa³¹ŸToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie ga³êzi";

            

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.Nodes.Add(dialog.nazwa);
                
            }
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (treeView1.SelectedNode == null)
            {
                return;
            }

            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie podga³êŸi";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(dialog.nazwa);
            }

        }

        private void zmieñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                return;
            }
            Form2 dialog = new Form2();
            dialog.Text = "Modyfikowanie ga³êŸi";
            dialog.nazwa = treeView1.SelectedNode.Text;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = dialog.nazwa;
            }
        }

        private void usuñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZapisDoPliku();
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Zapisaæ zmiany przed zamkniêciem?",
                                 "Zamykanie", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                ZapisDoPliku();
                Application.Exit();
            }
            else if (res == DialogResult.No)
            {
                Application.Exit();
            }
        }
        private void OdczytZPliku()
        {
            treeView1.Nodes.Clear();
            List<myNode> lista = new List<myNode>();
            string[] tab = File.ReadAllLines("firma.txt");
            foreach(string elem in tab)
            {
                string[] pom = elem.Split(' ');
                lista.Add(new myNode(pom[1], pom[2]));
            }
            foreach(myNode node in lista)
            {
                if (node.rodzic == "brak")
                    treeView1.Nodes.Add(new TreeNode(node.nazwa));
                else
                {
                  /*  //TreeNode rodzic = ZnajdzRodzica(node.rodzic);
                    if (rodzic != null)
                        rodzic.Nodes.Add(node.nazwa);*/
                }
            }
        }
        private TreeNode ZnajdzRodzica(string rodzic)
        {
            /* TreeNode ew = 
             return null;*/
            string[] tab = File.ReadAllLines("firma.txt");
            foreach(string elem in tab)
            {
                
            }
            foreach (myNode item in lista)
            {

            }
        }

        
    }
}