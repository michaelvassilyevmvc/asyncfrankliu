namespace OffloadApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        lblMessage = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Location = new System.Drawing.Point(130, 294);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(145, 42);
        button1.TabIndex = 0;
        button1.Text = "Message 1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Location = new System.Drawing.Point(378, 295);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(154, 40);
        button2.TabIndex = 1;
        button2.Text = "Message 2";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // lblMessage
        // 
        lblMessage.Location = new System.Drawing.Point(243, 174);
        lblMessage.Name = "lblMessage";
        lblMessage.Size = new System.Drawing.Size(318, 23);
        lblMessage.TabIndex = 2;
        lblMessage.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblMessage);
        Controls.Add(button2);
        Controls.Add(button1);
        Text = "Form1";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label lblMessage;

    #endregion
}