﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DataGridView1 = New DataGridView()
        Me.Label1 = New Label()
        Me.TextBox1 = New TextBox()
        Me.Button1 = New Button()
        Me.MenuStrip1 = New MenuStrip()
        Me.OpenFileDialog1 = New OpenFileDialog()
        Me.SampleControl1 = New WinFormsControl.SampleControl()
        Me.FileToolStripMenuItem = New ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New ToolStripMenuItem()
        Me.RunToolStripMenuItem = New ToolStripMenuItem()
        Me.CountToolStripMenuItem = New ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        ' DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(22, 168)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(240, 150)
        Me.DataGridView1.TabIndex = 0
        '
        ' Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        ' TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(81, 50)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(332, 23)
        Me.TextBox1.TabIndex = 2
        '
        ' Button1
        '
        Me.Button1.Location = New System.Drawing.Point(22, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        ' MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New ToolStripItem() {Me.FileToolStripMenuItem, Me.RunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(516, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        ' OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        ' FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        ' ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        ' RunToolStripMenuItem
        '
        Me.RunToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {Me.CountToolStripMenuItem})
        Me.RunToolStripMenuItem.Name = "RunToolStripMenuItem"
        Me.RunToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.RunToolStripMenuItem.Text = "&Run"
        '
        ' CountToolStripMenuItem
        '
        Me.CountToolStripMenuItem.Name = "CountToolStripMenuItem"
        Me.CountToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CountToolStripMenuItem.Text = "&Count"
        '
        ' SampleControl1
        '
        SampleControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        SampleControl1.Font = New Font("ＭＳ ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SampleControl1.InputText = ""
        SampleControl1.Location = New Point(16, 40)
        SampleControl1.MaximumSize = New Size(0, 104)
        SampleControl1.MinimumSize = New Size(256, 104)
        SampleControl1.Name = "SampleControl1"
        SampleControl1.OutputText = ""
        SampleControl1.Size = New Size(400, 104)
        SampleControl1.TabIndex = 5

        '
        ' Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(432, 345)
        Me.Controls.Add(SampleControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RunToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SampleControl1 As WinFormsControl.SampleControl
End Class
