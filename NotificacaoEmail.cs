 class NotificacaoEmail : INotificacao
{
    public override void Enviar()
    {
        Console.WriteLine("Enviando notificação por Email...");
    }

    public void Enviar(string anexo)
    {
        Console.WriteLine("Enviando Email com anexo: " + anexo);
    }
}