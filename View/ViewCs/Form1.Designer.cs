namespace ViewCs
{

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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        this.Button1 = new System.Windows.Forms.Button();
        this.TextBox1 = new System.Windows.Forms.TextBox();
        this.Label1 = new System.Windows.Forms.Label();
        this.DataGridView1 = new System.Windows.Forms.DataGridView();
        this.SampleControl1 = new WinFormsControl.SampleControl();

        ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
        this.SuspendLayout();

        //
        // Button1
        //
        this.Button1.Location = new System.Drawing.Point(12, 64);
        this.Button1.Name = "Button1";
        this.Button1.Size = new System.Drawing.Size(110, 31);
        this.Button1.TabIndex = 7;
        this.Button1.Text = "Button1";
        this.Button1.UseVisualStyleBackColor = true;
        this.Button1.Click += this.Button1_Click;
        //
        // TextBox1
        //
        this.TextBox1.Location = new System.Drawing.Point(71, 21);
        this.TextBox1.Name = "TextBox1";
        this.TextBox1.Size = new System.Drawing.Size(332, 23);
        this.TextBox1.TabIndex = 6;
        //
        // Label1
        //
        this.Label1.AutoSize = true;
        this.Label1.Location = new System.Drawing.Point(12, 21);
        this.Label1.Name = "Label1";
        this.Label1.Size = new System.Drawing.Size(41, 15);
        this.Label1.TabIndex = 5;
        this.Label1.Text = "Label1";
        //
        // DataGridView1
        //
        this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        resources.ApplyResources(this.DataGridView1, "DataGridView1");
        this.DataGridView1.Name = "DataGridView1";
        this.DataGridView1.RowTemplate.Height = 25;
        //
        // SampleControl1
        //
        resources.ApplyResources(SampleControl1, "SampleControl1");
        this.SampleControl1.InputText = "";
        this.SampleControl1.Name = "SampleControl1";
        this.SampleControl1.OutputText = "";
        this.SampleControl1.RunButtonClick += this.SampleControl1_RunButtonClick;

        //
        // Form1
        //
        this.AutoScaleMode = AutoScaleMode.None;
        resources.ApplyResources(this, "$this");
        this.Controls.Add(this.SampleControl1);
        this.Controls.Add(this.Button1);
        this.Controls.Add(this.TextBox1);
        this.Controls.Add(this.Label1);
        this.Controls.Add(this.DataGridView1);
        this.Name = "Form1";

        ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    #endregion

    internal Button Button1;
    internal TextBox TextBox1;
    internal Label Label1;
    internal DataGridView DataGridView1;
    internal WinFormsControl.SampleControl SampleControl1;
}

}
