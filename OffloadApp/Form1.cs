namespace OffloadApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Thread.Sleep(2000);
        lblMessage.Text = "First Message";
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Thread.Sleep(3000);
        lblMessage.Text = "Second Message";
    }
}