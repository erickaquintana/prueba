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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button1.Font = New Font("Algerian", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Blue
        Button1.Location = New Point(319, 126)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 27)
        Button1.TabIndex = 0
        Button1.Text = "Ericka"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button2.Font = New Font("Algerian", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.Blue
        Button2.Location = New Point(319, 199)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 27)
        Button2.TabIndex = 1
        Button2.Text = "Luis David"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        Button3.Font = New Font("Algerian", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.Blue
        Button3.Location = New Point(319, 258)
        Button3.Name = "Button3"
        Button3.Size = New Size(145, 33)
        Button3.TabIndex = 2
        Button3.Text = "Trabajo"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
