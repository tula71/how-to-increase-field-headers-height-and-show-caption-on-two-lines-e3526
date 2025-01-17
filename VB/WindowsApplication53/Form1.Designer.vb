﻿Namespace WindowsApplication53
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
            Me.dataSet1 = New System.Data.DataSet()
            Me.dataTable1 = New System.Data.DataTable()
            Me.dataColumn1 = New System.Data.DataColumn()
            Me.dataColumn2 = New System.Data.DataColumn()
            Me.dataColumn3 = New System.Data.DataColumn()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.pivotGridControl1 = New WindowsApplication53.MyPivotGridControl()
            Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldValue2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dataSet1
            ' 
            Me.dataSet1.DataSetName = "NewDataSet"
            Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
            ' 
            ' dataTable1
            ' 
            Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
            Me.dataTable1.TableName = "Data"
            ' 
            ' dataColumn1
            ' 
            Me.dataColumn1.ColumnName = "Name"
            ' 
            ' dataColumn2
            ' 
            Me.dataColumn2.ColumnName = "Date"
            Me.dataColumn2.DataType = GetType(Date)
            ' 
            ' dataColumn3
            ' 
            Me.dataColumn3.ColumnName = "Value"
            Me.dataColumn3.DataType = GetType(Decimal)
            ' 
            ' panel1
            ' 
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.panel1.Location = New System.Drawing.Point(596, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(200, 292)
            Me.panel1.TabIndex = 1
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(385, 0)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(99, 38)
            Me.simpleButton1.TabIndex = 2
            Me.simpleButton1.Text = "Export"
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Appearance.FieldHeader.Options.UseTextOptions = True
            Me.pivotGridControl1.Appearance.FieldHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.pivotGridControl1.DataMember = "Data"
            Me.pivotGridControl1.DataSource = Me.dataSet1
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fieldName, Me.fieldDate, Me.fieldValue, Me.fieldValue1, Me.fieldValue2, Me.fieldDate1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsDataField.ColumnValueLineCount = 2
            Me.pivotGridControl1.Size = New System.Drawing.Size(596, 292)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' fieldName
            ' 
            Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName.AreaIndex = 0
            Me.fieldName.Caption = "This is header of Name"
            Me.fieldName.FieldName = "Name"
            Me.fieldName.Name = "fieldName"
            ' 
            ' fieldDate
            ' 
            Me.fieldDate.AreaIndex = 1
            Me.fieldDate.Caption = "This is header of Year"
            Me.fieldDate.FieldName = "Date"
            Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldDate.Name = "fieldDate"
            Me.fieldDate.UnboundFieldName = "fieldDate"
            Me.fieldDate.Width = 40
            ' 
            ' fieldValue
            ' 
            Me.fieldValue.Appearance.Value.Options.UseTextOptions = True
            Me.fieldValue.Appearance.Value.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue.AreaIndex = 0
            Me.fieldValue.Caption = "This is header of Sum"
            Me.fieldValue.ColumnValueLineCount = 2
            Me.fieldValue.FieldName = "Value"
            Me.fieldValue.ImageIndex = 0
            Me.fieldValue.Name = "fieldValue"
            ' 
            ' fieldValue1
            ' 
            Me.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue1.AreaIndex = 1
            Me.fieldValue1.Caption = "Count"
            Me.fieldValue1.ColumnValueLineCount = 2
            Me.fieldValue1.FieldName = "Value"
            Me.fieldValue1.Name = "fieldValue1"
            Me.fieldValue1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
            Me.fieldValue1.Visible = False
            ' 
            ' fieldValue2
            ' 
            Me.fieldValue2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldValue2.AreaIndex = 2
            Me.fieldValue2.Caption = "Average"
            Me.fieldValue2.ColumnValueLineCount = 2
            Me.fieldValue2.FieldName = "Value"
            Me.fieldValue2.Name = "fieldValue2"
            Me.fieldValue2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldValue2.Visible = False
            ' 
            ' fieldDate1
            ' 
            Me.fieldDate1.AreaIndex = 0
            Me.fieldDate1.Caption = "This is header of Date"
            Me.fieldDate1.FieldName = "Date"
            Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
            Me.fieldDate1.Name = "fieldDate1"
            Me.fieldDate1.UnboundFieldName = "fieldDate1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(796, 292)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents pivotGridControl1 As MyPivotGridControl
        Private dataSet1 As System.Data.DataSet
        Private dataTable1 As System.Data.DataTable
        Private dataColumn1 As System.Data.DataColumn
        Private dataColumn2 As System.Data.DataColumn
        Private dataColumn3 As System.Data.DataColumn
        Private fieldName As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldValue2 As DevExpress.XtraPivotGrid.PivotGridField
        Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
        Private panel1 As System.Windows.Forms.Panel
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

