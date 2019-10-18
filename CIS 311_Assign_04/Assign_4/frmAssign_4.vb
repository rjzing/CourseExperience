'------------------------------------------------------------
'-                File Name : frmAssign_4.frm               - 
'-                Part of Project: Assign1                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 02/21/2018                    -
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
Public Class frmAssign_4
    Dim dicAllRawIngredients As New Dictionary(Of String, String)
    Dim dicAllPreppedItems As New Dictionary(Of String, Dictionary(Of String, String))
    Dim dicAllDishes As New Dictionary(Of String, Dictionary(Of String, Dictionary(Of String, String)))

    '------------------------------------------------------------
    '-        Subprogram Name: fnLoadInDefaultRawIngri          -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads, it sets   -
    '- all the default raw ingredients                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
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
    '-    Subprogram Name: fnLoadInDefaultAllPreppedItems       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads, it sets   -
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
        Fries.Add("Fries", "Fries") 'end of fries
        Fries.Clear()
        dicAllPreppedItems.Add("Fries", Fries) 'add Fries
        SoftDrink.Add("Soft Drink", "Soft Drink") 'end of softdrink
        SoftDrink.Clear()
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
    '-           Subprogram Name: frmAssign_4_Load              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign_4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call fnLoadInDefaultRawIngri()
        Call fnLoadInDefaultAllPreppedItems()
        For Each strAllIngredients In dicAllRawIngredients.Keys
            lstAllRawIngridents.Items.Add(strAllIngredients)
        Next
        For Each strAllPreppedItems In dicAllPreppedItems.Keys
            lstAllPreppedItems.Items.Add(strAllPreppedItems)
        Next
        For Each strSelectedDish In dicAllDishes.Keys
            lstDishes.Items.Add(strSelectedDish)
        Next
        btnLeftPreppedItems.Enabled = False
        btnLeftRawIngredients.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: lstDishes_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
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
            lstSelectedDishPreppedItems.Items.Clear()
            lstSelectedDishRawIngredients.Items.Clear()

            For Each strDishItems In dicAllDishes(strDishSelected).Keys
                lstSelectedDishPreppedItems.Items.Add(strDishItems)
            Next
            btnLeftPreppedItems.Enabled = True

        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: lstAllPreppedItems_Click           -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
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

    Private Sub lstAllPreppedItems_Click(sender As Object, e As EventArgs) Handles lstAllPreppedItems.Click
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        lstSelectedDishRawIngredients.Items.Clear()
            For Each strPrepItems In dicAllPreppedItems(strPreppedItemSelected).Keys
                lstSelectedDishRawIngredients.Items.Add(strPrepItems)
            Next
        btnLeftRawIngredients.Enabled = True
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: txtNewDish_TextChanged          -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
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
    '-                Written On: 02/21/2018                    -
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
        Dim dicTempNewDish As New Dictionary(Of String, String)
        Dim dicTempDishWithoutPrepped As New Dictionary(Of String, Dictionary(Of String, String))
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
                dicTempNewDish.Add("", Nothing)
                dicTempDishWithoutPrepped.Add("", Nothing)
                dicTempDishWithoutPrepped.Clear()
                dicAllDishes.Add(strKey, dicTempDishWithoutPrepped)
                lstDishes.Items.Clear()
                txtNewDish.Clear()
                For Each strDish In dicAllDishes.Keys
                    lstDishes.Items.Add(strDish)
                Next
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
    '-                Written On: 02/21/2018                    -
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
    '-                Written On: 02/21/2018                    -
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
                lstAllPreppedItems.Items.Clear()
                txtNewPreppedItem.Clear()
                For Each strNewPreppedItem In dicAllPreppedItems.Keys
                    lstAllPreppedItems.Items.Add(strNewPreppedItem)
                Next
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
    '-                Written On: 02/21/2018                    -
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
    '-                Written On: 02/21/2018                    -
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
                lstAllRawIngridents.Items.Clear()
                txtNewRawIngredient.Clear()
                For Each strNewRawIngredients In dicAllRawIngredients.Keys
                    lstAllRawIngridents.Items.Add(strNewRawIngredients)
                Next
            Else
                MessageBox.Show("Raw ingridents already contains " & txtNewRawIngredient.Text)
                txtNewRawIngredient.Clear()
                btnAddNewRawIngredients.Enabled = False
            End If
        End If
        btnAddNewRawIngredients.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-       Subprogram Name: btnLeftPreppedItems_Click         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnLeftPreppedItems to add a prepped item to the current -
    '- selected dish                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- TempAddPreppedItem - dictionary to temporarily hold the  -
    '-      new item to add                                     -  
    '- DishSelected - holds the dish the user selected          -
    '- PreppedItemSelected - which prepped item will be added   -            
    '------------------------------------------------------------

    Private Sub btnLeftPreppedItems_Click(sender As Object, e As EventArgs) Handles btnLeftPreppedItems.Click
        Dim strDishSelected As String = lstDishes.SelectedItem
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        Dim dicTempAddPreppedItem As New Dictionary(Of String, String)
        If (lstAllPreppedItems.SelectedItem = Nothing) Then
            MessageBox.Show("Nothing selected in all prepped items")
        ElseIf (lstDishes.SelectedItem = Nothing) Then
            MessageBox.Show("No dish selected")
        Else
            If (dicAllDishes(strDishSelected).ContainsKey(strPreppedItemSelected) = True) Then
                MessageBox.Show("No need to include duplicate prepped items")
            Else
                dicTempAddPreppedItem.Add(strPreppedItemSelected, strPreppedItemSelected)
                lstSelectedDishPreppedItems.Items.Clear()
                dicAllDishes(strDishSelected).Add(strPreppedItemSelected, dicTempAddPreppedItem)
                For Each strPrepItems In dicAllDishes(strDishSelected).Keys
                    lstSelectedDishPreppedItems.Items.Add(strPrepItems)
                Next
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: btnRightPreppedItems_Click         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnRightPreppedItems to remove the selected prepped item -
    '- from the current selected dish                           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- DisheSelected - current dish selected                    - 
    '- PreppedItemSelected - current prepped item selected      -        
    '------------------------------------------------------------

    Private Sub btnRightPreppedItems_Click(sender As Object, e As EventArgs) Handles btnRightPreppedItems.Click
        Dim strDisheSelected As String = lstDishes.SelectedItem
        Dim strPreppedItemSelected As String = lstSelectedDishPreppedItems.SelectedItem
        If (lstSelectedDishPreppedItems.SelectedItem = Nothing) Then
            MessageBox.Show("Nothing selected in selected dish prepped items")
        Else
            lstSelectedDishPreppedItems.Items.Clear()
            dicAllDishes(strDisheSelected).Remove(strPreppedItemSelected)
            For Each strPreppedItems In dicAllDishes(strDisheSelected).Keys
                lstSelectedDishPreppedItems.Items.Add(strPreppedItems)
            Next
        End If
    End Sub

    '------------------------------------------------------------
    '-      Subprogram Name: btnLeftRawIngredients_Click        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnLeftRawIngredients to add a raw ingredient to the     -
    '- current selected dish                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- PreppedItemSelected - current prepped item selected      - 
    '- RawIngriSelected -raw ingredient to move to selected dish-          
    '------------------------------------------------------------

    Private Sub btnLeftRawIngredients_Click(sender As Object, e As EventArgs) Handles btnLeftRawIngredients.Click
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        Dim strRawIngriSelected As String = lstAllRawIngridents.SelectedItem
        If (lstAllRawIngridents.SelectedItem = Nothing) Then
            MessageBox.Show("Nothing selected in all raw Ingredients")
        ElseIf (lstAllPreppedItems.SelectedItem = Nothing) Then
            MessageBox.Show("Nothing selected in all prepped items")
        Else
            If (dicAllPreppedItems(strPreppedItemSelected).ContainsKey(strRawIngriSelected) = True) Then
                MessageBox.Show("No need to include duplicate raw ingredients")
            Else
                lstSelectedDishRawIngredients.Items.Clear()
                dicAllPreppedItems(strPreppedItemSelected).Add(strRawIngriSelected, strRawIngriSelected)
                For Each strRawIngri In dicAllPreppedItems(strPreppedItemSelected).Keys
                    lstSelectedDishRawIngredients.Items.Add(strRawIngri)
                Next
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-     Subprogram Name: btnRightRawIngredients_Click        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks       -
    '- btnRightRawIngredients to remove the selected raw        -
    '- ingredient from selected dish                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- PreppedItemSelected - current prepped item selected      -
    '- RawIngriSelected - current raw ingri selected            -        
    '------------------------------------------------------------

    Private Sub btnRightRawIngredients_Click(sender As Object, e As EventArgs) Handles btnRightRawIngredients.Click
        Dim strPreppedItemSelected As String = lstAllPreppedItems.SelectedItem
        Dim strRawIngriSelected As String = lstSelectedDishRawIngredients.SelectedItem
        If (lstSelectedDishRawIngredients.SelectedItem = Nothing) Then
            MessageBox.Show("Nothing selected in selected dish raw ingredients")
        Else
            lstSelectedDishRawIngredients.Items.Clear()
            dicAllPreppedItems(strPreppedItemSelected).Remove(strRawIngriSelected)
            For Each strRawIngri In dicAllPreppedItems(strPreppedItemSelected).Keys
                lstSelectedDishRawIngredients.Items.Add(strRawIngri)
            Next
        End If
    End Sub
End Class