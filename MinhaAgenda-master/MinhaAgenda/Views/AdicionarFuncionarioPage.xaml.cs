using CasosDeUso.Interface;

namespace MinhaAgenda.Views;

public partial class AdicionarFuncionarioPage : ContentPage
{
    private readonly IAdicionarFuncionarioUseCase _adicionarFuncionarioUseCase;

	public AdicionarFuncionarioPage(IAdicionarFuncionarioUseCase adicionarFuncionarioUseCase)
	{
		InitializeComponent();
        _adicionarFuncionarioUseCase = adicionarFuncionarioUseCase;
	}

    private async void contatoCtrl_OnSave(object sender, EventArgs e)
    {
        await _adicionarFuncionarioUseCase.ExecutaAsync(new CoreBusiness.Entidades.Funcionario(contatosCtrl.Name, contatosCtrl.Idade, contatosCtrl.Sexo, contatosCtrl.Cargo, contatosCtrl.Observacao));
    }

    private void contatosCtrl_OnError(object sender, string e)
    {
        DisplayAlert("Erro", e, "Ok");
    }
}