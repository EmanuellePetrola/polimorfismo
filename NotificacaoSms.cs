class NotificacaoSMS : INotificacao
{
    public override void Enviar()
    {
        Console.WriteLine("Enviando notificação por SMS...");
    }
}
