Namespace WorkingWithCells
	Partial Class FormattingCellRange
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridDesktop1 = New Aspose.Cells.GridDesktop.GridDesktop()
			Me.SuspendLayout()
			' 
			' gridDesktop1
			' 
			Me.gridDesktop1.ActiveSheetIndex = 0
			Me.gridDesktop1.ActiveSheetNameFont = Nothing
			Me.gridDesktop1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
			Me.gridDesktop1.CommentDisplayingFont = New System.Drawing.Font("Arial", 9F)
			Me.gridDesktop1.IsHorizontalScrollBarVisible = True
			Me.gridDesktop1.IsVerticalScrollBarVisible = True
			Me.gridDesktop1.Location = New System.Drawing.Point(12, 12)
			Me.gridDesktop1.Name = "gridDesktop1"
			Me.gridDesktop1.SheetNameFont = New System.Drawing.Font("Verdana", 8F)
			Me.gridDesktop1.SheetTabWidth = 400
			Me.gridDesktop1.Size = New System.Drawing.Size(636, 398)
			Me.gridDesktop1.TabIndex = 7
			' 
			' FormattingCellRange
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(660, 422)
			Me.Controls.Add(Me.gridDesktop1)
			Me.Name = "FormattingCellRange"
			Me.Text = "Formatting Cell Range"
			AddHandler Me.Load, New System.EventHandler(AddressOf Me.FormattingCellRange_Load)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridDesktop1 As Aspose.Cells.GridDesktop.GridDesktop
	End Class
End Namespace
