namespace Pronostico.API.Outils
{
    public class ApiResult<T>
    {
        public bool IsSuccess { get; set; }
        public string? CodErreur { get; set; }
        public string? LibErreur { get; set; }
        public  T? Data { get; set; }

        public static ApiResult<T> Ok(T data) => new() { IsSuccess = true, Data = data };

        public static ApiResult<T> Erreur(string codErreur, string libErreur)
        {
            return new() { IsSuccess = false, CodErreur = codErreur, LibErreur = libErreur };
        }
    }

    public class ApiResultFuncHelper
    {
        public static ApiResult<T> TryEx<T>(Func<T> func)
        {
            try
            {
                return ApiResult<T>.Ok(func());
            }
            catch(MetierException mex)
            {
                return ApiResult<T>.Erreur(Libelles.ERRCOD_EX, mex.Message);
            }
            catch (Exception ex)
            {
                //Todo pour le moment je renvoie en message le message de l'exception
                // A l'avenir ne pas préciser à l'utilisateur le détail de l'erreur si erreur non métier
                return ApiResult<T>.Erreur(Libelles.ERRCOD_EX,ex.Message);
            }
        }
    }
}
