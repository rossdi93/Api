using System;

namespace Api.Model
{
    /// <summary>
    /// класс пользователя
    /// </summary>
    public class UserModel: BaseModel
    {
        /// <summary>
        /// имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// логин польователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// пароль пользователя
        /// </summary>
        public string Pass { get; set; }

    }
}
