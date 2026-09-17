class NotificacaoPush : INotificacao
{
    public override void Enviar()
    {
        Console.WriteLine("Enviando notificação Push para o App...");
    }
}

