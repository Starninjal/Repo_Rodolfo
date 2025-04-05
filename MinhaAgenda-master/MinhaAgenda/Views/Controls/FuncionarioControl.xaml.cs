using System.Reflection.Metadata.Ecma335;
namespace MinhaAgenda.Views.Controls;

public partial class FuncionarioControl : ContentView
{
	public event EventHandler<string> OnError;
	public event EventHandler<EventArgs> OnSave;
	public event EventHandler<EventArgs> OnCancel;
	public FuncionarioControl()
	{
		InitializeComponent();
	}

	public string Name { get { return entryName.Text; } set { entryName.Text = value; } }
	public int Idade { get { return Convert.ToInt32(entryIdade.Text); } set { entryIdade.Text = Convert.ToString(value); } }

	public string Sexo { get { return entrySexo.Text; } set { entrySexo.Text = value;  } }
	public string Cargo { get { return entrySexo.Text; } set { entrySexo.Text = value; } }
	public string Observacao { get { return entryObservacao.Text; } set { entryObservacao.Text = value; } }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
		if (nameValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Um nome é obrigatório");
			return;
		}
		if(sexoValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Um gênero é obrigatório");
			return;
		}
		if(idadeValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Uma idade é");	
			return;
		}
		if(cargoValidator.IsNotValid)
		{
			OnError?.Invoke(sender, "Um cargo é obrigatório!");
			return;
		}
        OnSave?.Invoke(sender, e);
    }
}