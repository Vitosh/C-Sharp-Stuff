        string test = "AAAaaFATSEPARATORzzZZZ";
        string first = test.Substring(0, test.IndexOf("FATSEPARATOR"));
        string second = test.Substring(test.IndexOf("FATSEPARATOR") + 12);
