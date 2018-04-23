Namespace WinForms_MapControl_VecLayer_DataLoadedEvent
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
            Me.bLoadData = New System.Windows.Forms.Button()
            Me.lLayerState = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            ' 
            ' bLoadData
            ' 
            Me.bLoadData.Location = New System.Drawing.Point(12, 12)
            Me.bLoadData.Name = "bLoadData"
            Me.bLoadData.Size = New System.Drawing.Size(75, 23)
            Me.bLoadData.TabIndex = 1
            Me.bLoadData.Text = "Load Data"
            Me.bLoadData.UseVisualStyleBackColor = True
            ' 
            ' lLayerState
            ' 
            Me.lLayerState.AutoSize = True
            Me.lLayerState.Location = New System.Drawing.Point(12, 38)
            Me.lLayerState.Name = "lLayerState"
            Me.lLayerState.Size = New System.Drawing.Size(0, 13)
            Me.lLayerState.TabIndex = 2
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(606, 443)
            Me.Controls.Add(Me.lLayerState)
            Me.Controls.Add(Me.bLoadData)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private WithEvents bLoadData As System.Windows.Forms.Button
        Private lLayerState As System.Windows.Forms.Label
    End Class
End Namespace

