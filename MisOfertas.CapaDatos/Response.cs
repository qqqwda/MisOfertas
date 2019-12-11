namespace MisOfertas.CapaDatos
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Answer { get; set; }

        public Response()
        {
            IsSuccess = false;
            //Answer = null;
        }
    }
}
