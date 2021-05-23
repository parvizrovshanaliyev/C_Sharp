
#region ToDoListDocument
/*
 * 1. todolist form acilacaq onun icerisinde login formu olmalidir, bu ikinci form
 * todolist formunun icerisinde olacaq
 *
 * form sizeable olmasin
 * mdicontainer (butun formlar burada acilir)
 *
 * Panel SideBar:
 * Position sol teref
 * form side bar panel tool ile duzeldilecek sol terefe yapismasi ucun dock ozelliyi
 * Todolist acilan zaman ilk emeliyyati ancaq login formunda ede biler deye sidebar uzerindeki buttonlar secile
 * bilmemelidir.
 *
 * New : Yeni todo yaradilacaq
 *     - Yaradilan TodoEntity-e esasen yeni bir form penceresi yaradilmalidir.
 *     Acilan form penceresi TodoList formunun childi olacaq yeni mdiParent=this,
 *     New button basilan zaman eger NewTodo form aciq olarsa yeni form acilmamalidir.
 *
 * Get All : Butun todo-lar gosterilecek
 * Exit: Application.Exit
 *
 *
 * timer: 15 saniye intervalla yenilecek ve cari vaxti gosterecek
 *
 *
 * *******login :
 * Login formu Todolist formunun child formu oldugundan todolist acilan zaman
 * onun icerisinde merkezde acilmalidir.
 * none border,
 * TabOrder,
 * event enter: inputlarin rengi deyishsin
 *
 * username ve passoword ucun yoxlama aparilir ilkinde onlarin required oldugu bildirilmelidir.
 *
 * Click login btn:
 * Login zamani istifadeci a. sifrenin db-da olub olmamasini yoxlayiriq, geriye qayidan user
 * user == null ise Xeta mesaji vereceyik.
 *
 * user != null deyilse Form daki group box icerisinde olan buttonlar enable edilmelidir,
 * ardindan Login form baglanmalidir, RAM-daki open forms hissesine aid isler gorulmelidir.
 *
 *
 * Project Structure
 *
 * Business
 *       -Abstract
 *       -Concrete
 * DataAccess
 *       -Abstract
 *       -Concrete
 * Entities
 *       -Abstract
 *       -Concrete : User, Todo
 *        
 */


#endregion


