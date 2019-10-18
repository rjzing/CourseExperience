'------------------------------------------------------------
'-                File Name : frmAssign_7.vb                - 
'-                Part of Project: Assign 7                 -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 03/28/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the   -
'- user will select a dish, loading selected dish prepped   -
'- items, selected dish raw ingredients, and all prepped    -
'- items and all raw ingredients. The user can also add new -
'- dishes, prepped items, and raw ingredients.              -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to interact with a form showing-
'- selected dish info and all info with the ablility to add -
'- items if they want.                                      -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- AllDishes – dictionary holding all dishes and their      –
'-      respective info(prepped items, raw ingredients      -
'- AllPreppedItems - dictionary holding all prepped items   - 
'-      and raw ingredients                                 -
'- AllRawIngredients -dictionary holding all raw ingreidents-
'------------------------------------------------------------
Public Class frmAssign_7
    Dim dicAllRawIngredients As New Dictionary(Of String, String)
    Dim dicAllPreppedItems As New Dictionary(Of String, Dictionary(Of String, String))
    Dim dicAllDishes As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))

    '------------------------------------------------------------
    '-        Function Name: fnLoadInDefaultRawIngri            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function is called when the form loads, it sets     -
    '- all the default raw ingredients                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Dictionary – all raw ingridents                          -
    '------------------------------------------------------------
    Function fnLoadInDefaultRawIngri()
        dicAllRawIngredients.Add("Beef Patty", "Beef Patty")
        dicAllRawIngredients.Add("Ketchup", "Ketchup")
        dicAllRawIngredients.Add("Mustard", "Mustard")
        dicAllRawIngredients.Add("Bun", "Bun")
        dicAllRawIngredients.Add("Mayo", "Mayo")
        dicAllRawIngredients.Add("Lettuce", "Lettuce")
        'end of burger ingri
        dicAllRawIngredients.Add("Crust", "Crust")
        dicAllRawIngredients.Add("Sauce", "Sauce")
        dicAllRawIngredients.Add("Cheese", "Cheese")
        dicAllRawIngredients.Add("Pepperoni", "Pepperoni")
        dicAllRawIngredients.Add("Bacon", "Bacon")
        'end of pizza ingri
        Return dicAllRawIngredients
    End Function

    '------------------------------------------------------------
    '-     Function Name: fnLoadInDefaultAllPreppedItems        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function is called when the form loads, it sets     -
    '- all the default prepped items and dishes                 -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- HamburgerDishPreppedItems - dictionary that holds the    -
    '-      hamburgerdish's prepped items                       -
    '- PizzaDishPreppedItems - dictionary that holds the pizza's-
    '-      prepped items                                       - 
    '- Fries -dictionary that holds fries to include with burger-
    '- Hamburger - dictionary that holds the dictionary of items-
    '- Pizza - dictionary that holds the dictionary of items    -
    '- SoftDrink - dictionary that holds soft drink to include  -
    '-      with each dish
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Dictionary – all prepped items and dishes                -
    '------------------------------------------------------------
    Function fnLoadInDefaultAllPreppedItems()
        Dim Hamburger As New Dictionary(Of String, String)
        Dim SoftDrink As New Dictionary(Of String, String)
        Dim Fries As New Dictionary(Of String, String)
        Dim Pizza As New Dictionary(Of String, String)
        Dim dicPizzaDishPreppedItems As New Dictionary(Of String, Dictionary(Of String, String))
        Dim dicHamburgerDishPreppedItems As New Dictionary(Of String, Dictionary(Of String, String))
        Hamburger.Add("Beef Patty", dicAllRawIngredients.Values(0))
        Hamburger.Add("Ketchup", dicAllRawIngredients.Values(1))
        Hamburger.Add("Mustard", dicAllRawIngredients.Values(2))
        Hamburger.Add("Bun", dicAllRawIngredients.Values(3))
        Hamburger.Add("Mayo", dicAllRawIngredients.Values(4))
        Hamburger.Add("Lettuce", dicAllRawIngredients.Values(5))
        'end of hamburger raw ingri
        dicAllPreppedItems.Add("Hamburger", Hamburger) 'add Hamburger
        Pizza.Add("Crust", dicAllRawIngredients.Values(6))
        Pizza.Add("Sauce", dicAllRawIngredients.Values(7))
        Pizza.Add("Cheese", dicAllRawIngredients.Values(8))
        Pizza.Add("Pepperoni", dicAllRawIngredients.Values(9))
        Pizza.Add("Bacon", dicAllRawIngredients.Values(10))
        'end of pizza raw ingri
        dicAllPreppedItems.Add("Pizza", Pizza) 'add Pizza
        Fries.Add("Fries", "Fries")
        Fries.Clear() 'end of fries
        dicAllPreppedItems.Add("Fries", Fries) 'add Fries
        SoftDrink.Add("Soft Drink", "Soft Drink")
        SoftDrink.Clear() 'end of softdrink
        dicAllPreppedItems.Add("Soft Drink", SoftDrink) 'add softdrink
        dicHamburgerDishPreppedItems.Add("Hamburger", Hamburger)
        dicHamburgerDishPreppedItems.Add("Soft Drink", SoftDrink)
        dicHamburgerDishPreppedItems.Add("Fries", Fries)
        'end of hamburgerdish
        dicPizzaDishPreppedItems.Add("Pizza", Pizza)
        dicPizzaDishPreppedItems.Add("Soft Drink", SoftDrink)
        'end of pizzadish
        dicAllDishes.Add("Hamburger Dish", dicHamburgerDishPreppedItems) 'adds hamburgerdish
        dicAllDishes.Add("Pizza Dish", dicPizzaDishPreppedItems) 'adds pizzadish
        Return dicAllPreppedItems
    End Function

    '------------------------------------------------------------
    '-     Subprogram Name: refreshSelectedDishPreppedItem      -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user adds a new       -
    '- prepped item from all prepped items to the selected dish -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- DishSelected – the current dish selected                 -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub refreshSelectedDishPreppedItem(strDishSelected)
        lstSelectedDishPreppedItems.Items.Clear()
        For Each strPreppedItems In dicAllDishes(strDishSelected).Keys
            lstSelectedDishPreppedItems.Items.Add(strPreppedItems)
        Next
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: refreshSelectedDishRawIngri        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user adds a new raw   -
    '- ingredient from all raw ingredients to the selected      -
    '- prepped item                                             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- PreppedItemSelected – current prepped item selected      -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub refreshSelectedDishRawIngri(strPreppedItemSelected)
        lstSelectedDishRawIngredients.Items.Clear()
        For Each strRawIngri In dicAllPreppedItems(strPreppedItemSelected).Keys
            lstSelectedDishRawIngredients.Items.Add(strRawIngri)
        Next
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: refreshAllDishes             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads and when   -
    '- the user adds a new dish to all dishes                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub refreshAllDishes()
        lstDishes.Items.Clear()
        txtNewDish.Clear()
        For Each strSelectedDish In dicAllDishes.Keys
            lstDishes.Items.Add(strSelectedDish)
        Next
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: refreshAllPreppedItems           -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads and when   -
    '- the user adds a new prepped item to all prepped items    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub refreshAllPreppedItems()
        lstAllPreppedItems.Items.Clear()
        txtNewPreppedItem.Clear()
        For Each strAllPreppedItems In dicAllPreppedItems.Keys
            lstAllPreppedItems.Items.Add(strAllPreppedItems)
        Next
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: refreshAllIngri             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads and when   -
    '- the user adds a new ingredient to all ingredients        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub refreshAllIngri()
        lstAllRawIngridents.Items.Clear()
        txtNewRawIngredient.Clear()
        For Each strAllIngredients In dicAllRawIngredients.Keys
            lstAllRawIngridents.Items.Add(strAllIngredients)
        Next
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: frmAssign_7_Load              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads, adding all-
    '- preloaded dictionaries and displays them in their        -
    '- respective list boxes                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign_7_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call fnLoadInDefaultRawIngri()
        Call fnLoadInDefaultAllPreppedItems()
        Call refreshAllDishes()
        Call refreshAllPreppedItems()
        Call refreshAllIngri()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: lstDishes_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- lstDishes, also checks if there was an item clicked and  -
    '- then populates the lstSelectedDishPreppedItems           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strDishSelected - the item that the user selects         -
    '------------------------------------------------------------
    Private Sub lstDishes_Click(sender As Object, e As EventArgs) Handles lstDishes.Click
        Dim strDishSelected As String = lstDishes.SelectedItem
        If (lstDishes.SelectedItem = Nothing) Then
            MessageBox.Show("No dish selected")
        Else
            lstSelectedDishRawIngredients.Items.Clear()
            Call refreshSelectedDishPreppedItem(strDishSelected)

        End If
    End Sub

    '------------------------------------------------------------
    '- Subprogram Name: lstAllPreppedItems_MouseCaptureChanged  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- lstAllPreppedItems which populates                       -
    '- lstSelectedDishRawIngredients                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strPreppedItemSelected - the item the user selects       -
    '------------------------------------------------------------
    Private Sub lstAllPreppedItems_MouseCaptureChanged(sender As Object, e As EventArgs) Handles lstAllPreppedItems.MouseCaptureChanged
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        lstSelectedDishRawIngredients.Items.Clear()
        If (lstAllPreppedItems.SelectedItem = Nothing) Then
        Else
            For Each strPrepItems In dicAllPreppedItems(strPreppedItemSelected).Keys
                lstSelectedDishRawIngredients.Items.Add(strPrepItems)
            Next
        End If
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: txtNewDish_TextChanged          -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters text  -
    '- in txtNewDish and enables the button to actually add a   -
    '- new dish to the dish dictionary                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtNewDish_TextChanged(sender As Object, e As EventArgs) Handles txtNewDish.TextChanged
        btnAddNewDish.Enabled = True
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: btnAddNewDish_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnAddNewDish to submit the change to dicAllDishes.      -
    '- I decided to make everything uppercase to fool proof     -
    '- checking for duplicates                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- NewDish - dictionary that place holds the final new dish -
    '- TempNewDish - dictionary that holds the actual text      -
    '- UpperCaseAllDishes - AllDishes uppercased to compare     -
    '- strKey - holds the text in string form                   -
    '- strKeyUpper - uppercase text to compare to AllDishes.keys-
    '- strUpperCaseAddDish - place holder for the text as it    -
    '-      transformed                                         -
    '------------------------------------------------------------
    Private Sub btnAddNewDish_Click(sender As Object, e As EventArgs) Handles btnAddNewDish.Click
        Dim dicUpperCaseAllDishes As New Dictionary(Of String, String)
        Dim strUpperCaseAddDish As String
        Dim strKeyUpper As String
        Dim strKey As String
        Dim dicNewDish As New Dictionary(Of String, String)
        Dim dicTempNewDish As New Dictionary(Of String, Dictionary(Of String, String))
        strUpperCaseAddDish = UCase(txtNewDish.Text)
        For Each strUpperDishes In dicAllDishes.Keys
            strKeyUpper = UCase(strUpperDishes)
            dicUpperCaseAllDishes.Add(strKeyUpper, strKeyUpper)
        Next
        If (txtNewDish.Text = Nothing) Then
            MessageBox.Show("Don't trick me! There's nothing to add!")
        Else
            If (dicUpperCaseAllDishes.ContainsKey(strUpperCaseAddDish) = False) Then
                strKey = txtNewDish.Text
                dicNewDish.Add("", Nothing)
                dicTempNewDish.Add("", Nothing)
                dicTempNewDish.Clear()
                dicAllDishes.Add(strKey, dicTempNewDish)
                Call refreshAllDishes()
            Else
                MessageBox.Show("Dishes already contains " & txtNewDish.Text)
                txtNewDish.Clear()
                btnAddNewDish.Enabled = False
            End If
        End If
        btnAddNewDish.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-     Subprogram Name: txtNewPreppedItem_TextChanged       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters text  -
    '- in txtNewPreppedItem and enables the button to actually  -
    '- add a new prepped item to the preppeditem dictionary     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtNewPreppedItem_TextChanged(sender As Object, e As EventArgs) Handles txtNewPreppedItem.TextChanged
        btnAddNewPreppedItems.Enabled = True
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: btnAddNewPreppedItems_Click        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnAddNewPreppedItems to submit the change to all prepped-
    '- items. Again I made everything uppercase in order to     -
    '- check for duplicates                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- NewPreppedItem - dictionary that place holds the final   -
    '-      new prepped item                                    -  
    '- UpperCaseAllPreppedItems - holds current prepped items   -
    '-      after they were changed to uppercase                -
    '- strKey - holds the text in string form                   -
    '- strKeyUpper -uppercase text to compare to AllPrepped.keys-
    '- strUpperCaseAddPreppedItem - place holder for the text as-
    '-      its transformed                                     -
    '------------------------------------------------------------
    Private Sub btnAddNewPreppedItems_Click(sender As Object, e As EventArgs) Handles btnAddNewPreppedItems.Click
        Dim dicUpperCaseAllPreppedItems As New Dictionary(Of String, String)
        Dim strUpperCaseAddPreppedItem As String
        Dim strKeyUpper As String
        Dim strKey As String
        Dim dicNewPreppedItem As New Dictionary(Of String, String)
        strUpperCaseAddPreppedItem = UCase(txtNewPreppedItem.Text)
        For Each strUpperPreppedItems In dicAllPreppedItems.Keys
            strKeyUpper = UCase(strUpperPreppedItems)
            dicUpperCaseAllPreppedItems.Add(strKeyUpper, strKeyUpper)
        Next
        If (txtNewPreppedItem.Text = Nothing) Then
            MessageBox.Show("Trying to trick me again, huh?!")
        Else
            If (dicUpperCaseAllPreppedItems.ContainsKey(strUpperCaseAddPreppedItem) = False) Then
                strKey = txtNewPreppedItem.Text
                dicAllPreppedItems.Add(strKey, dicNewPreppedItem)
                Call refreshAllPreppedItems()
            Else
                MessageBox.Show("Prepped items already contains " & txtNewPreppedItem.Text)
                txtNewPreppedItem.Clear()
                btnAddNewPreppedItems.Enabled = False
            End If
        End If
        btnAddNewPreppedItems.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-    Subprogram Name: txtNewRawIngredient_TextChanged      -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters text  -
    '- in txtNewRawIngredient and enables the button to actually-
    '- add a new raw ingredients to the dictionary              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtNewRawIngredient_TextChanged(sender As Object, e As EventArgs) Handles txtNewRawIngredient.TextChanged
        btnAddNewRawIngredients.Enabled = True
    End Sub

    '------------------------------------------------------------
    '-     Subprogram Name: btnAddNewRawIngredients_Click       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnAddNewRawIngredients to submit the change to all raw  -
    '- ingredients. Again I made everything uppercase in order  -
    '- to check for duplicates                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- UpperCaseAllIngri -holds the all ingredients in uppercase-
    '-      letters                                             -  
    '- strKey - holds the text in string form                   -
    '- strKeyUpper -uppercase text to compare to AllIngri.keys  -
    '- strUpperCaseAddRawIngri - place holder for the text as   -
    '-      its transformed                                     -
    '------------------------------------------------------------
    Private Sub btnAddNewRawIngredients_Click(sender As Object, e As EventArgs) Handles btnAddNewRawIngredients.Click
        Dim dicUpperCaseAllIngri As New Dictionary(Of String, String)
        Dim strUpperCaseAddRawIngri As String
        Dim strKeyUpper As String
        Dim strKey As String
        strUpperCaseAddRawIngri = UCase(txtNewRawIngredient.Text)
        For Each strUpperPreppedItems In dicAllRawIngredients.Keys
            strKeyUpper = UCase(strUpperPreppedItems)
            dicUpperCaseAllIngri.Add(strKeyUpper, strKeyUpper)
        Next
        If (txtNewRawIngredient.Text = Nothing) Then
            MessageBox.Show("Not Again!")
        Else
            If (dicUpperCaseAllIngri.ContainsKey(strUpperCaseAddRawIngri) = False) Then
                strKey = txtNewRawIngredient.Text
                dicAllRawIngredients.Add(strKey, strKey)
                Call refreshAllIngri()
            Else
                MessageBox.Show("Raw ingridents already contains " & txtNewRawIngredient.Text)
                txtNewRawIngredient.Clear()
                btnAddNewRawIngredients.Enabled = False
            End If
        End If
        btnAddNewRawIngredients.Enabled = False
    End Sub

    'selected dish raw ingri item add

    '------------------------------------------------------------
    '-  Subprogram Name: lstSelectedDishRawIngredients_DragDrop -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user drops the    -
    '- selected all raw ingri to add them to the selected       -
    '- prepped item                                             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- IngrisSelected - the current raw ingris selected         -
    '- PreppedItemSelected - current prepped item selected      -          
    '------------------------------------------------------------
    Private Sub lstSelectedDishRawIngredients_DragDrop(sender As Object, e As DragEventArgs) Handles lstSelectedDishRawIngredients.DragDrop
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        Dim strIngrisSelected = lstAllRawIngridents.SelectedItems
        If (strPreppedItemSelected = Nothing) Then
            MessageBox.Show("No Prepped Item selected")
        ElseIf (lstAllPreppedItems.SelectedItems.Count() > 1) Then
            MessageBox.Show("Select one prepped item before adding raw ingridents")
        Else
            For Each strIngriSelected In strIngrisSelected
                If (dicAllPreppedItems(strPreppedItemSelected).ContainsKey(strIngriSelected)) Then
                Else
                    dicAllPreppedItems(strPreppedItemSelected).Add(strIngriSelected, strIngriSelected)
                    Call refreshSelectedDishRawIngri(strPreppedItemSelected)
                End If
            Next
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllRawIngridents_MouseDown      -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks down  -
    '- the mouse to allow the drag and drop operation on the    -
    '- selected raw ingris                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- MoveToSelectedDishIngri - changes the cursor to show a   -
    '-      drag and drop operation is possible                 -
    '- ToggleOn - case to be passed to toggleOnDrags            -
    '------------------------------------------------------------
    Private Sub lstAllRawIngridents_MouseDown(sender As Object, e As MouseEventArgs) Handles lstAllRawIngridents.MouseDown
        Dim ddeMoveToSelectedDishIngri As DragDropEffects
        Dim intToggleOn As Integer = 0
        Call toggleAllDragOff()
        Call toggleOnDrags(intToggleOn)
        If (lstAllRawIngridents.SelectedItem = Nothing) Then
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                For Each itemsSelected In lstAllRawIngridents.SelectedIndices
                    ddeMoveToSelectedDishIngri = lstAllRawIngridents.DoDragDrop(lstAllRawIngridents.Items(itemsSelected), DragDropEffects.All Or DragDropEffects.Link)
                Next
            Else
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllRawIngridents_DragEnter      -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters the   -
    '- listbox and alerts the user they can drop the items in   -
    '- this list box                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstSelectedDishRawIngredients_DragEnter(sender As Object, e As DragEventArgs) Handles lstSelectedDishRawIngredients.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    'selected dish prepped item add

    '------------------------------------------------------------
    '-  Subprogram Name: lstSelectedDishPreppedItems_DragDrop   -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user drops the    -
    '- selected all prepped items to add them to the selected   -
    '- dish's prepped item                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- DishSelected - the current dish selected                 -
    '- PreppedItemsSelected - current prepped items selected    -  
    '- TempAddPreppedItem - the temp dictionary item to add     -
    '------------------------------------------------------------
    Private Sub lstSelectedDishPreppedItems_DragDrop(sender As Object, e As DragEventArgs) Handles lstSelectedDishPreppedItems.DragDrop
        Dim strDishSelected As String = lstDishes.SelectedItem
        Dim PreppedItemsSelected = lstAllPreppedItems.SelectedItems
        Dim dicTempAddPreppedItem As New Dictionary(Of String, String)
        If (strDishSelected = Nothing) Then
            MessageBox.Show("No dish selected")
        Else
            For Each strPreppedItemSelected In PreppedItemsSelected
                If (dicAllDishes(strDishSelected).ContainsKey(strPreppedItemSelected)) Then
                Else
                    dicTempAddPreppedItem.Add(strPreppedItemSelected, strPreppedItemSelected)
                    dicAllDishes(strDishSelected).Add(strPreppedItemSelected, dicTempAddPreppedItem)
                    Call refreshSelectedDishPreppedItem(strDishSelected)
                End If
            Next
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllPreppedItems_MouseDown       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks down  -
    '- the mouse to allow the drag and drop operation on the    -
    '- selected prepped items                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- MoveToSelectedDishPreppedItem - changes the cursor to    -
    '-      show a drag and drop operation is possible          -
    '- ToggleOn - case to be passed to toggleOnDrags            -
    '------------------------------------------------------------
    Private Sub lstAllPreppedItems_MouseDown(sender As Object, e As MouseEventArgs) Handles lstAllPreppedItems.MouseDown
        Dim ddeMoveToSelectedDishPreppedItem As DragDropEffects
        Dim intToggleOn As Integer = 1
        Call toggleAllDragOff()
        Call toggleOnDrags(intToggleOn)
        If (lstAllPreppedItems.SelectedItem = Nothing) Then
        Else
            If e.Button = Windows.Forms.MouseButtons.Left Then
                For Each itemsSelected In lstAllPreppedItems.SelectedIndices
                    ddeMoveToSelectedDishPreppedItem = lstAllPreppedItems.DoDragDrop(lstAllPreppedItems.Items(itemsSelected), DragDropEffects.All Or DragDropEffects.Link)
                Next
            Else
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllRawIngridents_DragEnter      -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters the   -
    '- listbox and alerts the user they can drop the items in   -
    '- this list box                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstSelectedDishPreppedItems_DragEnter(sender As Object, e As DragEventArgs) Handles lstSelectedDishPreppedItems.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    'selected dish prepped item remove

    '------------------------------------------------------------
    '-       Subprogram Name: lstAllPreppedItems_DragDrop       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user drops the    -
    '- selected dish prepped items to remove the selected       -
    '- dish's prepped items                                     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- DishSelected - the current dish selected                 -
    '- selectedDishPreppedItems - current prepped items selected-  
    '-      to remove                                           -
    '------------------------------------------------------------
    Private Sub lstAllPreppedItems_DragDrop(sender As Object, e As DragEventArgs) Handles lstAllPreppedItems.DragDrop
        Dim strDishSelected As String = lstDishes.SelectedItem
        Dim selectedDishPreppedItems = lstSelectedDishPreppedItems.SelectedItems
        If (strDishSelected = Nothing) Then
            MessageBox.Show("No dish selected")
        Else
            For Each selectedDishPreppedItemsToBeRemoved In selectedDishPreppedItems
                dicAllDishes(strDishSelected).Remove(selectedDishPreppedItemsToBeRemoved)
            Next
            Call refreshSelectedDishPreppedItem(strDishSelected)
        End If
    End Sub

    '------------------------------------------------------------
    '-  Subprogram Name: lstSelectedDishPreppedItems_MouseDown  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks down  -
    '- the mouse to allow the drag and drop operation on the    -
    '- selected dish prepped items                              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- MoveToAllPreppedItems - changes the cursor to show a drag-
    '-      and drop operation is possible                      -
    '- ToggleOn - case to be passed to toggleOnDrags            -
    '------------------------------------------------------------
    Private Sub lstSelectedDishPreppedItems_MouseDown(sender As Object, e As MouseEventArgs) Handles lstSelectedDishPreppedItems.MouseDown
        Dim ddeMoveToAllPreppedItems As DragDropEffects
        Dim intToggleOn As Integer = 2
        Call toggleAllDragOff()
        Call toggleOnDrags(intToggleOn)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            For Each itemsSelected In lstSelectedDishPreppedItems.SelectedIndices
                ddeMoveToAllPreppedItems = lstSelectedDishPreppedItems.DoDragDrop(lstSelectedDishPreppedItems.Items(itemsSelected), DragDropEffects.All Or DragDropEffects.Link)
            Next
        Else
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllPreppedItems_DragEnter       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters the   -
    '- listbox and alerts the user they can drop the items in   -
    '- this list box                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstAllPreppedItems_DragEnter(sender As Object, e As DragEventArgs) Handles lstAllPreppedItems.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    'selected dish raw ingri remove

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllRawIngridents_DragDrop       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user drops the    -
    '- selected prepped item ingri to remove the selected       -
    '- ingris                                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- selectedDishRawIngri - the current ingris selected       -
    '- PreppedItemSelected - current prepped item selected      -  
    '------------------------------------------------------------
    Private Sub lstAllRawIngridents_DragDrop(sender As Object, e As DragEventArgs) Handles lstAllRawIngridents.DragDrop
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        Dim selectedDishRawIngri = lstSelectedDishRawIngredients.SelectedItems
        If (strPreppedItemSelected = Nothing) Then
            MessageBox.Show("No dish selected")
        ElseIf (lstAllPreppedItems.SelectedItems.Count() > 1) Then
            MessageBox.Show("Select one prepped item before removing raw ingridents")
        Else
            For Each selectedDishRawIngriToBeRemoved In selectedDishRawIngri
                dicAllPreppedItems(strPreppedItemSelected).Remove(selectedDishRawIngriToBeRemoved)
            Next
            Call refreshSelectedDishRawIngri(strPreppedItemSelected)
        End If
    End Sub

    '------------------------------------------------------------
    '-    Subprogram Name: lstSelectedDishRawIngri_MouseDown    -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks down  -
    '- the mouse to allow the drag and drop operation on the    -
    '- selected prepped items ingri                             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- MoveToAllRawIngri - changes the cursor to show a drag and-
    '-      drop operation is possible                          -
    '- ToggleOn - case to be passed to toggleOnDrags            -
    '------------------------------------------------------------
    Private Sub lstSelectedDishRawIngri_MouseDown(sender As Object, e As MouseEventArgs) Handles lstSelectedDishRawIngredients.MouseDown
        Dim ddeMoveToAllRawIngri As DragDropEffects
        Dim intToggleOn As Integer = 3
        Call toggleAllDragOff()
        Call toggleOnDrags(intToggleOn)
        If e.Button = Windows.Forms.MouseButtons.Left Then
            For Each itemsSelected In lstSelectedDishRawIngredients.SelectedIndices
                ddeMoveToAllRawIngri = lstSelectedDishRawIngredients.DoDragDrop(lstSelectedDishRawIngredients.Items(itemsSelected), DragDropEffects.All Or DragDropEffects.Link)
            Next
        Else
        End If
    End Sub

    '------------------------------------------------------------
    '-     Subprogram Name: lstAllRawIngridents_DragEnter       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user enters the   -
    '- listbox and alerts the user they can drop the items in   -
    '- this list box                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub lstAllRawIngridents_DragEnter(sender As Object, e As DragEventArgs) Handles lstAllRawIngridents.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: toggleAllDragOff             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks on the-
    '- items in a list box, disabling all drag and drop         -
    '- operations, allowing only one drag and drop destination  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub toggleAllDragOff()
        lstAllRawIngridents.AllowDrop = False
        lstAllPreppedItems.AllowDrop = False
        lstSelectedDishPreppedItems.AllowDrop = False
        lstSelectedDishRawIngredients.AllowDrop = False
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: toggleOnDrags              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks on a  -
    '- list box that allows the drag and drop operation, making -
    '- one and only one destination list box to drop selected   -
    '- items                                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- toToggleOn - keeps track of which list box should be     -
    '-      enabled                                             -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub toggleOnDrags(toToggleOn)
        If (toToggleOn = 0) Then
            lstSelectedDishRawIngredients.AllowDrop = True
        ElseIf (toToggleOn = 1) Then
            lstSelectedDishPreppedItems.AllowDrop = True
        ElseIf (toToggleOn = 2) Then
            lstAllPreppedItems.AllowDrop = True
        ElseIf (toToggleOn = 3) Then
            lstAllRawIngridents.AllowDrop = True
        End If
    End Sub
End Class