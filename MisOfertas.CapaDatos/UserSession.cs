namespace MisOfertas.CapaDatos
{
    public class UserSession
    {
        public string Email { get; set; }
        public string Rut { get; set; }
        public int IdUserType { get; set; }

        public string Message { get; set; }

        public bool IsSuccess { get; set; }


        public UserSession()
        {
            this.IsSuccess = false;
            this.Email = string.Empty;
            this.Rut = string.Empty;
            this.Message = string.Empty;

        }
    }
}
