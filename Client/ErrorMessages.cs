using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static internal class ErrorMessages
    {
        static public string EmptyError => "Поле не должно быть пустым";

        static public string LessCharacterError => "Пароль должен содержать 8 символов";

        static public string SpacePasswordError => "Пароль не должен содержать пробелы";

        static public string MatchError => "Пароли должны совпадать";

        static public string RegisterError => "Такой аккаунт уже существует";

    }
}
