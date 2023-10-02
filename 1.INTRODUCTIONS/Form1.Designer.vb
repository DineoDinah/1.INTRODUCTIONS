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
		Button1 = New Button()
		CheckBox1 = New CheckBox()
		CheckBox2 = New CheckBox()
		Label1 = New Label()
		Label2 = New Label()
		Label3 = New Label()
		Label4 = New Label()
		ComboBox1 = New ComboBox()
		TextBox1 = New TextBox()
		RadioButton1 = New RadioButton()
		RadioButton2 = New RadioButton()
		RadioButton3 = New RadioButton()
		TextBox2 = New TextBox()
		SuspendLayout()
		' 
		' Button1
		' 
		Button1.Location = New Point(570, 393)
		Button1.Name = "Button1"
		Button1.Size = New Size(112, 34)
		Button1.TabIndex = 0
		Button1.Text = "Click Here"
		Button1.UseVisualStyleBackColor = True
		' 
		' CheckBox1
		' 
		CheckBox1.AutoSize = True
		CheckBox1.Location = New Point(356, 323)
		CheckBox1.Name = "CheckBox1"
		CheckBox1.Size = New Size(101, 29)
		CheckBox1.TabIndex = 1
		CheckBox1.Text = "Sign Up"
		CheckBox1.UseVisualStyleBackColor = True
		' 
		' CheckBox2
		' 
		CheckBox2.AutoSize = True
		CheckBox2.Location = New Point(356, 288)
		CheckBox2.Name = "CheckBox2"
		CheckBox2.Size = New Size(115, 29)
		CheckBox2.TabIndex = 1
		CheckBox2.Text = "Subscribe"
		CheckBox2.UseVisualStyleBackColor = True
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Location = New Point(143, 219)
		Label1.Name = "Label1"
		Label1.Size = New Size(95, 25)
		Label1.TabIndex = 2
		Label1.Text = "Profession"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Segoe UI Black", 20F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
		Label2.Location = New Point(116, 36)
		Label2.Name = "Label2"
		Label2.Size = New Size(566, 54)
		Label2.TabIndex = 2
		Label2.Text = "Sign Up For  Mindworx LMS"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Location = New Point(143, 177)
		Label3.Name = "Label3"
		Label3.Size = New Size(82, 25)
		Label3.TabIndex = 2
		Label3.Text = "Surname"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.Location = New Point(143, 134)
		Label4.Name = "Label4"
		Label4.Size = New Size(59, 25)
		Label4.TabIndex = 2
		Label4.Text = "Name"
		' 
		' ComboBox1
		' 
		ComboBox1.FormattingEnabled = True
		ComboBox1.Items.AddRange(New Object() {"Student ", "Teacher", "Manager"})
		ComboBox1.Location = New Point(324, 219)
		ComboBox1.Name = "ComboBox1"
		ComboBox1.Size = New Size(182, 33)
		ComboBox1.TabIndex = 3
		' 
		' TextBox1
		' 
		TextBox1.Location = New Point(356, 134)
		TextBox1.Name = "TextBox1"
		TextBox1.Size = New Size(150, 31)
		TextBox1.TabIndex = 4
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.Location = New Point(598, 132)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(75, 29)
		RadioButton1.TabIndex = 5
		RadioButton1.TabStop = True
		RadioButton1.Text = "Male"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' RadioButton2
		' 
		RadioButton2.AutoSize = True
		RadioButton2.Location = New Point(598, 167)
		RadioButton2.Name = "RadioButton2"
		RadioButton2.Size = New Size(93, 29)
		RadioButton2.TabIndex = 5
		RadioButton2.TabStop = True
		RadioButton2.Text = "Female"
		RadioButton2.UseVisualStyleBackColor = True
		' 
		' RadioButton3
		' 
		RadioButton3.AutoSize = True
		RadioButton3.Location = New Point(598, 202)
		RadioButton3.Name = "RadioButton3"
		RadioButton3.Size = New Size(82, 29)
		RadioButton3.TabIndex = 5
		RadioButton3.TabStop = True
		RadioButton3.Text = "Other"
		RadioButton3.UseVisualStyleBackColor = True
		' 
		' TextBox2
		' 
		TextBox2.Location = New Point(356, 177)
		TextBox2.Name = "TextBox2"
		TextBox2.Size = New Size(150, 31)
		TextBox2.TabIndex = 4
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(10F, 25F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = SystemColors.Info
		ClientSize = New Size(800, 450)
		Controls.Add(RadioButton3)
		Controls.Add(RadioButton2)
		Controls.Add(TextBox2)
		Controls.Add(RadioButton1)
		Controls.Add(TextBox1)
		Controls.Add(ComboBox1)
		Controls.Add(Label4)
		Controls.Add(Label3)
		Controls.Add(Label2)
		Controls.Add(Label1)
		Controls.Add(CheckBox2)
		Controls.Add(CheckBox1)
		Controls.Add(Button1)
		Name = "Form1"
		Text = "Form1"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents Button1 As Button
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents TextBox2 As TextBox
End Class
