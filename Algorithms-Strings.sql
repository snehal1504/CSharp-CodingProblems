//Algorithms-Strings

public static int minimumNumber(int n, string password)
    {
        string numbers = "0123456789";
        string lower_case = "abcdefghijklmnopqrstuvwxyz";
        string upper_case = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string special_characters = "!@#$%^&*()-+";
        
        int lengthRequirement = 6-n;
        int missingTypes = 0;
				if(!password.Any(p=> numbers.Contains(p)))
                    missingTypes++;   
                if(!password.Any(p=> lower_case.Contains(p)))
                    missingTypes++;
                if(!password.Any(p=> upper_case.Contains(p)))
                    missingTypes++;
                if(!password.Any(p=> special_characters.Contains(p)))
                    missingTypes++;
            
        
        return Math.Max(missingTypes, lengthRequirement);
    }
