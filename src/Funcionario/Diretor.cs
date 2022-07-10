﻿namespace bytebank_adm.Funcionario;

public class Diretor : Funcionario
{
    public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
    {
    }

    public override double AumentaSalario()
    {
        return Salario *= 1.15;
    }

    public override double GetBonificacao()
    {
        return Salario + 0.17;
    }
}