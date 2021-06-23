namespace Adapter.Pagamentos
{
    class Token
    {
        private string _token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.FbKTj7e538znDUWdk5pXoUn9cPpKvGhPsy5X0Bs_wds";

        public string GetToken()
        {
            return _token;
        }
    }
}
