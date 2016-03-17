using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarCode.Models
{
    /// <summary>
    /// userDto
    /// </summary
    /// <author>Jon</author>
    public class UserDto
    {
        private string plantNo = string.Empty;

        /// <summary>
        /// 工厂号 Plant number
        /// </summary>
        public string PlantNo
        {
            get { return plantNo; }
            set { plantNo = value; }
        }

        private string userName = string.Empty;

        /// <summary>
        /// 用户名 User Name
        /// </summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        private string password = string.Empty;


        /// <summary>
        /// 密码 Password
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private string userID = string.Empty;

        public string UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        /// <summary>
        /// THB == Beijing  DMX == Xiamen
        /// </summary>
        private string logicCode = string.Empty;

        public string LogicCode
        {
            get { return logicCode; }
            set { logicCode = value; }
        }

        /// <summary>
        /// THB == Beijing  DMX == Xiamen
        /// </summary>
        private string _Location = string.Empty;

        public string Location
        {
            get { return _Location; }
            set { _Location = value; }
        }

        private string[] _MulPlantNo;

        public string[] MulPlantNo
        {
            get { return _MulPlantNo; }
            set { _MulPlantNo = value; }
        }
        string _PickingListQty;
        /// <summary>
        /// Picking List默认数量
        /// </summary>
        public string PickingListQty
        {
            get { return _PickingListQty; }
            set { _PickingListQty = value; }
        }


        string _LocationName;
        /// <summary>
        /// LocationName
        /// </summary>
        public string LocationName
        {
            get { return _LocationName; }
            set { _LocationName = value; }
        }

    }
}
