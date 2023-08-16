<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnDoSomething = New Button()
        rtbMessages = New RichTextBox()
        SuspendLayout()
        ' 
        ' btnDoSomething
        ' 
        btnDoSomething.Location = New Point(57, 27)
        btnDoSomething.Name = "btnDoSomething"
        btnDoSomething.Size = New Size(119, 23)
        btnDoSomething.TabIndex = 0
        btnDoSomething.Text = "Do Something"
        btnDoSomething.UseVisualStyleBackColor = True
        ' 
        ' rtbMessages
        ' 
        rtbMessages.Location = New Point(57, 67)
        rtbMessages.Name = "rtbMessages"
        rtbMessages.Size = New Size(249, 104)
        rtbMessages.TabIndex = 1
        rtbMessages.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(rtbMessages)
        Controls.Add(btnDoSomething)
        Name = "Form1"
        Text = "VBWinFormSimple"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnDoSomething As Button
    Friend WithEvents rtbMessages As RichTextBox
End Class
