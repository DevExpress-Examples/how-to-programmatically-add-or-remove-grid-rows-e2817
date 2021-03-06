﻿Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes

Namespace AddRemoveDataRows
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			grid.ItemsSource = New ProductList()
		End Sub

		Private Sub AddButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			TryCast(grid.ItemsSource, ProductList).Add(New Product() With {.ProductName = "(Empty) Product Name"})
		End Sub

		Private Sub DeleteButton_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If grid.IsValidRowHandle(view.FocusedRowHandle) Then
				view.DeleteRow(view.FocusedRowHandle)
			End If
		End Sub
	End Class
End Namespace
