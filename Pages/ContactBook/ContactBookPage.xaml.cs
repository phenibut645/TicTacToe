namespace alexm_app.Pages.ContactBook;

public partial class ContactBookPage : ContentPage
{
	public VerticalStackLayout MainContainer { get; set; } = new VerticalStackLayout();
	public TableView TableView { get; set; } 
	public ImageCell ImageCell { get; set; }
	public SwitchCell SwitchCell { get; set; }
	public TableSection FotoSection { get; set; }
	public ContactBookPage()
	{
		Content = MainContainer;

		TableView = new TableView
		{
			Intent = TableIntent.Form,
			Root = new TableRoot("Andmete sisestamine")
			{
				new TableSection("P�hiandmed:")
				{
					new EntryCell
					{
						Label = "Nimi:",
						Placeholder = "Sisesta oma s�bra nimi",
						Keyboard = Keyboard.Default
					}
				},
				new TableSection("Kontaktandmed:")
				{
					new EntryCell
					{
						Label = "Telefon",
						Placeholder = "Sisesta tel. number",
						Keyboard = Keyboard.Telephone
					},
					new EntryCell
					{
						Label = "Email",                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
						Placeholder = "Sisesta email",
						Keyboard = Keyboard.Email
					}
				}

			}
		};
		MainContainer.Children.Add(TableView);
	}
}