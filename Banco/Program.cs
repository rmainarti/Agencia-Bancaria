using Banco;

ContaCorrente ContadoAndre = new ContaCorrente();


ContadoAndre.titular = "André Macedo";
ContadoAndre.numero_agencia = 15;
ContadoAndre.conta = "1010-5";
ContadoAndre.saldo = 360;

Console.WriteLine("Titular: " + ContadoAndre.titular);
Console.WriteLine("Agencia: " + ContadoAndre.numero_agencia);
Console.WriteLine("Conta " + ContadoAndre.conta);
Console.WriteLine("Saldo da conta =  " + ContadoAndre.saldo);


ContadoAndre.Depositar(100);

Console.WriteLine("Saldo pós depósito =  " + ContadoAndre.saldo);

Console.WriteLine(" ");


ContaCorrente contadaMarcia = new ContaCorrente();
contadaMarcia.titular = "Marcia Pereira";
contadaMarcia.numero_agencia = 14;
contadaMarcia.conta = "1010-4";
contadaMarcia.saldo = 370;

Console.WriteLine("Titular: " + contadaMarcia.titular);
Console.WriteLine("Agencia: " + contadaMarcia.numero_agencia);
Console.WriteLine("Conta " + contadaMarcia.conta);
Console.WriteLine("Saldo da conta " + contadaMarcia.saldo);

Console.WriteLine(" ");

ContadoAndre.Transferir(50, contadaMarcia);
Console.WriteLine("Saldo do André após realizar transferência = " + ContadoAndre.saldo);
Console.WriteLine("Saldo da Marcia após receber transferência = " + contadaMarcia.saldo);






// logo abaixo método sacar valor em conta André
// método comentado na casse ContaCorrente

/*if (ContadoAndre.Sacar(20) == true)
{
    Console.WriteLine("Saldo pós Saque =  " + ContadoAndre.saldo);
}
else
{
    Console.WriteLine("Saque não realizado, valor deseja maior que saldo em conta");
}
*/