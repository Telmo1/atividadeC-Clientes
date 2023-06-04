using System;
namespace Atividade01_Clientes
{
class Program
{
static void Main(string[] args)
{
    float val_pag;
    Console.WriteLine("Informar Nome");
    string var_nome = Console.ReadLine();
    Console.WriteLine("Informar Endereço");
    string var_end = Console.ReadLine();
    Console.WriteLine("Pessoa Fisica (f) ou Pessoa Juridica (j)");
    string var_tipo = Console.ReadLine();

    if(var_tipo == "f") {
        // Pessoa Fisica

        pessoaFisica pf = new pessoaFisica();

        pf.nome = var_nome;
        pf.endereco = var_end;

        Console.WriteLine("Informar CPF");
        string var_cpf = Console.ReadLine();
        Console.WriteLine("Informar Valor de Compra:");
        val_pag = float.Parse(Console.ReadLine());
        pf.calculoImposto(val_pag);
        Console.WriteLine("-------- Pessoa Fisica ---------");

        Console.WriteLine("Nome ..........: " + pf.nome);
        Console.WriteLine("Endereço ......: " + pf.endereco);
        Console.WriteLine("CPF ...........: " + pf.cpf);
        Console.WriteLine("Valor de Compra: " + 
        pf.valor.ToString("C"));
        Console.WriteLine("Imposto .......: " + 
        pf.valorImposto.ToString("C"));
        Console.WriteLine("Total a Pagar : " + 
        pf.total.ToString("C"));

    }
        if(var_tipo == "j"){
            pessoaJuridica pj = new pessoaJuridica();
            pj.nome = var_nome;
            pj.endereco = var_end;

            Console.WriteLine("Informar CNPJ:");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.calculoImposto(val_pag);

            Console.WriteLine("-------- Pessoa Jurídica --------- ");
            Console.WriteLine("Nome ..........: " + pj.nome);
            Console.WriteLine("Endereço ......: " + pj.endereco);
            Console.WriteLine("CNPJ ..........: " + pj.cnpj);
            Console.WriteLine("Valor de Compra: " + 
            pj.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + 
            pj.valorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " + 
            pj.total.ToString("C"));
            }
        }
    }
}