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

        private void DodajGa���ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 dialog = new Form2();
            dialog.Text = "Dodawanie ga��zi";

            

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
            dialog.Text = "Dodawanie podga��i";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Nodes.Add(dialog.nazwa);
            }

        }

        private void zmie�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                return;
            }
            Form2 dialog = new Form2();
            dialog.Text = "Modyfikowanie ga��i";
            dialog.nazwa = treeView1.SelectedNode.Text;
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                treeView1.SelectedNode.Text = dialog.nazwa;
            }
        }

        private void usu�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Remove(treeView1.SelectedNode);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}