namespace Validations
{
	static class CPFValidation
	{
		private static readonly string[] listaCpfsInvalidos = {"00000000000",
												 "11111111111",
												 "22222222222",
												 "33333333333",
												 "44444444444",
												 "55555555555",
												 "66666666666",
												 "77777777777",
												 "88888888888",
												 "99999999999",
												 "12345678909"
												};

		private static readonly int[] _pesosCPF = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

		private static int[] getPesosPara(string valor)
		{
			var tamanhoValidacao = valor.Trim().Length;
			var tamanhoPesos = _pesosCPF.Length;
			var inicioCopia = tamanhoPesos - tamanhoValidacao;

			var result = new int[tamanhoValidacao];
			Array.Copy(_pesosCPF, inicioCopia, result, 0, result.Length);
			return result;
		}

		/* De acordo com http://pt.wikipedia.org/wiki/D%C3%ADgito_verificador*/
		private static string getDigitoVerificadorMod11Para(string valor)
		{
			var pesos = getPesosPara(valor);
			var soma = 0;
			for (var i = 0; i < valor.Trim().Length; i++)
			{
				soma += int.Parse(valor[i].ToString()) * pesos[i];
			}

			var resto = soma % 11;

			if (resto < 2)
			{
				resto = 11;
			}

			var digitoVerificador = 11 - resto;

			return digitoVerificador.ToString();
		}

		public static bool IsCpfValido(string cpf)
		{
			if (string.IsNullOrEmpty(cpf))
				return false;

			cpf = cpf.Trim();

			if (cpf.Length != 11)
				return false;

			long descarte;
			if (!long.TryParse(cpf, out descarte))
				return false;

			if (listaCpfsInvalidos.Contains(cpf))
				return false;


			var cpfSemDV = cpf.Trim().Substring(0, cpf.Trim().Length - 2);

			var primeiroDV = getDigitoVerificadorMod11Para(cpfSemDV);
			var segundoDV = getDigitoVerificadorMod11Para(cpfSemDV + primeiroDV);

			return cpf.EndsWith(primeiroDV + segundoDV);
		}
	}