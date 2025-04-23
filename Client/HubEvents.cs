namespace Client
{
    internal static class HubEvents
    {

        public static string Receive => "Receive";

        public static string Send => "Send";

        public static string DeleteMessage => "DeleteMessage";

        public static string DeleteMessageReceived => "DeleteMessageReceived";

        public static string Register => "Register";

        public static string RegisterReceived => "RegisterReceived";

        public static string Login => "Login";

        public static string LoginReceived => "LoginReceived";

        public static string Connected => "Connected";

        public static string ConnectedReceived => "ConnectedReceived";

        public static string ConnectedCallerReceived => "ConnectedCallerReceived";

        public static string Disconnected => "Disconnected";

        public static string DisconnectedReceived => "DisconnectedReceived";


    }
}