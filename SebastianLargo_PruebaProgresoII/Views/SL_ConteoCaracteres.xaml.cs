namespace SebastianLargo_PruebaProgresoII.Views;

public partial class SL_ConteoCaracteres : ContentPage
{
	public SL_ConteoCaracteres()
	{
		InitializeComponent();
	}
	private void OnCalculateClicked(object sender, EventArgs e)
	{
		string input = InputEntry.Text ?? string.Empty;

		int totalCharactersSL = input.Length;
		int letterCountSL = input.Count(char.IsLetter);
		int numberCountSL = input.Count(char.IsDigit);
		int vowelCountSL = input.Count(c => "aeiouAEIOU".Contains(c));
		int uppercaseCountSL = input.Count(char.IsUpper);
		int lowercaseCountSL = input.Count(char.IsLower);

		TotalCharactersLabel.Text = $"{totalCharactersSL}";
		LetterCountLabel.Text = $"{letterCountSL}";
		NumberCountLabel.Text = $"{numberCountSL}";
		VowelCountLabel.Text = $"{vowelCountSL}";
		UppercaseCountLabel.Text = $"{uppercaseCountSL}";
		LowercaseCountLabel.Text = $"{lowercaseCountSL}";
	}

	private void OnClearClicked(object sender, EventArgs e)
	{
		InputEntry.Text = string.Empty;
		TotalCharactersLabel.Text = string.Empty;
		LetterCountLabel.Text = string.Empty;
		NumberCountLabel.Text = string.Empty;
		VowelCountLabel.Text = string.Empty;
		UppercaseCountLabel.Text = string.Empty;
		LowercaseCountLabel.Text = string.Empty;
	}
}