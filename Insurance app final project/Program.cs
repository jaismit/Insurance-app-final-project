namespace Insurance_App
{
    internal class Program
    {


        //main process or when run...
        static void Main(string[] args)
        {

            Console.WriteLine(
" ______                                                                                        ______                      	    \n" +
"/      |                                                                                      /      \\                     	    \n" +
"$$$$$$/  _______    _______  __    __   ______   ______   _______    _______   ______        /$$$$$$  |  ______    ______  	    \n" +
"  $$ |  /       \\  /       |/  |  /  | /      \\ /      \\ /       \\  /       | /      \\       $$ |__$$ | /      \\  /      \\  \n" +
"  $$ |  $$$$$$$  |/$$$$$$$/ $$ |  $$ |/$$$$$$  |$$$$$$  |$$$$$$$  |/$$$$$$$/ /$$$$$$  |      $$    $$ |/$$$$$$  |/$$$$$$  |	    \n" +
"  $$ |  $$ |  $$ |$$      \\ $$ |  $$ |$$ |  $$/ /    $$ |$$ |  $$ |$$ |      $$    $$ |      $$$$$$$$ |$$ |  $$ |$$ |  $$ |	    \n" +
" _$$ |_ $$ |  $$ | $$$$$$  |$$ \\__$$ |$$ |     /$$$$$$$ |$$ |  $$ |$$ \\_____ $$$$$$$$/       $$ |  $$ |$$ |__$$ |$$ |__$$ |	    \n" +
"/ $$   |$$ |  $$ |/     $$/ $$    $$/ $$ |     $$    $$ |$$ |  $$ |$$       |$$       |      $$ |  $$ |$$    $$/ $$    $$/ 	    \n" +
"$$$$$$/ $$/   $$/ $$$$$$$/   $$$$$$/  $$/       $$$$$$$/ $$/   $$/  $$$$$$$/  $$$$$$$/       $$/   $$/ $$$$$$$/  $$$$$$$/  	    \n" +
"                                                                                                       $$ |      $$ |      	    \n" +
"                                                                                                       $$ |      $$ |      	    \n" +
"                                                                                                       $$/       $$/       	    \n"

);


            string add = "x";
            while (add.Equals("x"))
            {

                DeviceDetails();

                add = Add();


            }


        }




        //initialise a list of strings : categorys 
        static List<string> categorys = new List<string>()
        {
            "Laptop", "Desktop", "Other (such as smartphone or drone)"
        };

        //methods

        private static void DeviceDetails()
        {

            //global variables
            string category, deviceName;
            float deviceCost, deviceNumber;

            category = MenuChoice("category", categorys);
            Console.Clear();

            deviceName = CheckDeviceName();
            Console.Clear();

            deviceNumber = NumberOfDevices();
            Console.Clear();

            deviceCost = DeviceCost();
            Console.Clear();


            Console.WriteLine(
" ______                                                                                        ______                      	    \n" +
"/      |                                                                                      /      \\                     	    \n" +
"$$$$$$/  _______    _______  __    __   ______   ______   _______    _______   ______        /$$$$$$  |  ______    ______  	    \n" +
"  $$ |  /       \\  /       |/  |  /  | /      \\ /      \\ /       \\  /       | /      \\       $$ |__$$ | /      \\  /      \\  \n" +
"  $$ |  $$$$$$$  |/$$$$$$$/ $$ |  $$ |/$$$$$$  |$$$$$$  |$$$$$$$  |/$$$$$$$/ /$$$$$$  |      $$    $$ |/$$$$$$  |/$$$$$$  |	    \n" +
"  $$ |  $$ |  $$ |$$      \\ $$ |  $$ |$$ |  $$/ /    $$ |$$ |  $$ |$$ |      $$    $$ |      $$$$$$$$ |$$ |  $$ |$$ |  $$ |	    \n" +
" _$$ |_ $$ |  $$ | $$$$$$  |$$ \\__$$ |$$ |     /$$$$$$$ |$$ |  $$ |$$ \\_____ $$$$$$$$/       $$ |  $$ |$$ |__$$ |$$ |__$$ |	    \n" +
"/ $$   |$$ |  $$ |/     $$/ $$    $$/ $$ |     $$    $$ |$$ |  $$ |$$       |$$       |      $$ |  $$ |$$    $$/ $$    $$/ 	    \n" +
"$$$$$$/ $$/   $$/ $$$$$$$/   $$$$$$/  $$/       $$$$$$$/ $$/   $$/  $$$$$$$/  $$$$$$$/       $$/   $$/ $$$$$$$/  $$$$$$$/  	    \n" +
"                                                                                                       $$ |      $$ |      	    \n" +
"                                                                                                       $$ |      $$ |      	    \n" +
"                                                                                                       $$/       $$/       	    \n"

);
            Console.WriteLine($"Category: {category}\n" + $"Device Name: {deviceName}\n" + $"Number Of Devices: {deviceNumber}\n" + $"Cost For One Device: {deviceCost}\n" + $"Cost before insurance: {deviceNumber * deviceCost}\n" + $"Cost after insurance: {CalculateInsurance(deviceCost, deviceNumber)}\n");



            ValueLoss(deviceCost);

        }

        static float CalculateInsurance(float deviceCost, float numberOfDevices)
        {
            float costOne;

            if (numberOfDevices > 5)
            {
                costOne = (float)((numberOfDevices - 5) * deviceCost * .90);

                costOne += 5 * deviceCost;
            }

            else
            {
                costOne = numberOfDevices * deviceCost;
            }

            return costOne;

        }

        static void ValueLoss(float deviceCost)
        {
            float monthOne;
            float monthTwo;
            float monthThree;
            float monthFour;
            float monthFive;
            float monthSix;

            monthOne = (float)(deviceCost * .95);
            monthTwo = (float)(monthOne * .95);
            monthThree = (float)(monthTwo * .95);
            monthFour = (float)(monthThree * .95);
            monthFive = (float)(monthFour * .95);
            monthSix = (float)(monthFive * .95);



            Console.WriteLine($"Value loss\n" + $"Month 1: {Math.Round(monthOne, 2)}\n" + $"Month 2: {Math.Round(monthTwo, 2)}\n" + $"Month 3: {Math.Round(monthThree, 2)}\n" + $"Month 4: {Math.Round(monthFour, 2)}\n" + $"Month 5: {Math.Round(monthFive, 2)}\n" + $"Month 6: {Math.Round(monthSix, 2)}\n");


        }

        static string MenuChoice(string menuType, List<string> listData)
        {

            string menu = GenerateMenu(menuType, listData);

            return listData[CheckInt(menu, 1, listData.Count) - 1];
        }

        static int CheckInt(string question, int min, int max)
        {

            while (true)
            {
                try
                {
                    Console.WriteLine(question);

                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }

                    DisplayErrorMessage($"ERROR: You must enter an integer between {min} and {max}");
                }
                catch
                {
                    DisplayErrorMessage($"ERROR: You must enter an integer between {min} and {max}");
                }
            }


        }

        static string GenerateMenu(string menuType, List<string> listData)
        {


            string menu = $"Select the {menuType}:\n";

            for (int loop = 0; loop < listData.Count; loop++)
            {
                menu += $"{loop + 1}. {listData[loop]}\n";
            }

            return menu;
        }

        private static void DisplayErrorMessage(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ForegroundColor = ConsoleColor.White;
        }

        static string Add()
        {
            while (true)
            {
                Console.WriteLine("Enter 'x' to add another device");
                string add = Console.ReadLine();

                add = add.ToLower();

                if (add.Equals("x"))
                {
                    return add;
                }

                DisplayErrorMessage("Invalid choice");
            }
        }

        static string CheckDeviceName()
        {
            while (true)
            {
                Console.WriteLine("Enter the device name:\n");

                string deviceName = Console.ReadLine();

                if (!deviceName.Equals(""))
                {
                    deviceName = deviceName[0].ToString().ToUpper() + deviceName.Substring(1);

                    return deviceName;
                }

                DisplayErrorMessage("ERROR: You must ener a name");
            }

        }

        static float DeviceCost()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter device cost:\n");

                    float deviceCost = float.Parse(Console.ReadLine());


                    if (deviceCost > 0 && deviceCost < 10001)
                    {

                        return deviceCost;
                    }

                    DisplayErrorMessage("ERROR: You must enter a value between 1-10000");
                }
                catch
                {
                    DisplayErrorMessage("ERROR: You must enter a value between 1-10000");
                }

            }
        }
        static float NumberOfDevices()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of devices:\n");

                    float deviceNumber = float.Parse(Console.ReadLine());


                    if (deviceNumber > 0 && deviceNumber < 1001)
                    {

                        return deviceNumber;
                    }

                    DisplayErrorMessage("ERROR: You must enter a value between 1-1000");
                }
                catch
                {
                    DisplayErrorMessage("ERROR: You must enter a value between 1-1000");
                }


            }

        }

    }
}
