using System;
using System.Collections.Generic;

namespace NSTest {
    public class ToolRoomRequest {

        public List<ToolRoomRequest> requests() {
            List<ToolRoomRequest> ret = new List<ToolRoomRequest>();

            ret.Add(new ToolRoomRequest { ticket = 1001, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 1" });
            ret.Add(new ToolRoomRequest { ticket = 1002, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 2" });
            ret.Add(new ToolRoomRequest { ticket = 1003, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 3" });
            ret.Add(new ToolRoomRequest { ticket = 1004, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 4" });
            ret.Add(new ToolRoomRequest { ticket = 1005, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 5" });
            ret.Add(new ToolRoomRequest { ticket = 1006, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 6" });
            ret.Add(new ToolRoomRequest { ticket = 1007, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 7" });
            ret.Add(new ToolRoomRequest { ticket = 1008, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 8" });
            ret.Add(new ToolRoomRequest { ticket = 1009, requestDate = DateTime.Now, requestor = "33399", qty = 1, description = "desc 9" });
            return ret;
        }

        public int ticket { get; private set; }
        public int qty { get; private set; }
        public DateTime requestDate { get; private set; }
        public string requestor { get; private set; }
        public string description { get; private set; }
    }
}