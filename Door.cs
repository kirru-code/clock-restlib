using System;
using Rest_Service_1_1;

namespace CLock.RestLib
{
    public class Door
    {
        private string _doorName;
        private string _PrimaryKey;
        private string _SecondaryKey;
        private string _PrimaryThumbPrint;
        private string _SecondaryThumbPrint;
        private string _ConnectionString;
        private string _ConnectionState;
        private DateTime? _LastActivityTime;
        private DateTime? _LastConnectionTimeStateUpdateTime;
        private DateTime? _LastStateUpdateTime;
        private int? _MessageCount;
        private string _State;
        private string _SuspensionReason;
        private EnumDoorStatus _doorStatus;
        private EnumApplicationStatus _applicationStatus;


        public Door(string doorName, EnumDoorStatus doorStatus, EnumApplicationStatus applicationStatus)
        {
            _doorName = doorName;
            _doorStatus = doorStatus;
            _applicationStatus = applicationStatus;
        }
        public Door()
        {

        }

        public string DoorName { get => _doorName; set => _doorName = value; }
        public EnumDoorStatus DoorStatus { get => _doorStatus; set => _doorStatus = value; }
        public EnumApplicationStatus ApplicationStatus { get => _applicationStatus; set => _applicationStatus = value; }
        public string PrimaryKey { get => _PrimaryKey; set => _PrimaryKey = value; }
        public string SecondaryKey { get => _SecondaryKey; set => _SecondaryKey = value; }
        public string PrimaryThumbPrint { get => _PrimaryThumbPrint; set => _PrimaryThumbPrint = value; }
        public string SecondaryThumbPrint { get => _SecondaryThumbPrint; set => _SecondaryThumbPrint = value; }
        public string ConnectionString { get => _ConnectionString; set => _ConnectionString = value; }
        public string ConnectionState { get => _ConnectionState; set => _ConnectionState = value; }
        public DateTime? LastActivityTime { get => _LastActivityTime; set => _LastActivityTime = value; }
        public DateTime? LastConnectionTimeStateUpdateTime { get => _LastConnectionTimeStateUpdateTime; set => _LastConnectionTimeStateUpdateTime = value; }
        public DateTime? LastStateUpdateTime { get => _LastStateUpdateTime; set => _LastStateUpdateTime = value; }
        public int? MessageCount { get => _MessageCount; set => _MessageCount = value; }
        public string State { get => _State; set => _State = value; }
        public string SuspensionReason { get => _SuspensionReason; set => _SuspensionReason = value; }

        public void OpenDoor()
        {
            _doorStatus = EnumDoorStatus.open;
        }

        public void CloseDoor()
        {
            _doorStatus = EnumDoorStatus.closed;
        }

        public override string ToString()
        {
            return $"{DoorName};{DoorStatus}";
        }
    }
}