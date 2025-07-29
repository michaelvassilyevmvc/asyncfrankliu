namespace OffloadApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Thread thread = new Thread(() =>
        {
            ShowMessage("First Message", 2000);
        });
        thread.Start();
    }

    private void button2_Click(object sender, EventArgs e)
    {
        Thread tread = new Thread(() =>
        {
            ShowMessage("Second Message", 3000);
        });
        tread.Start();
    }
    
    void ShowMessage(string message, int delay)
    {
        Thread.Sleep(delay);
        lblMessage.Text = message;
    }
}