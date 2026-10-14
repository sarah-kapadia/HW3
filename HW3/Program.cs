using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // ARRAY: Stores course names
        string[] courses = new string[0];

        // LIST: Stores assignment names
        List<string> assignments = new List<string>();

        // DICTIONARY:
        // Key = Assignment Name
        // Value = Description and/or Progress Status
        Dictionary<string, string> assignmentDetails =new Dictionary<string, string>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n========================");
            Console.WriteLine("     ASSIGNMENT TRACKER");
            Console.WriteLine("========================");

            Console.WriteLine("1. Create Course (Array)");
            Console.WriteLine("2. Update Course (Array)");
            Console.WriteLine("3. Add Assignment (List)");
            Console.WriteLine("4. Update Assignment (List)");
            Console.WriteLine("5. Remove Assignment by Index (List)");
            Console.WriteLine("6. Add or Update Assignment Details (Dictionary)");
            Console.WriteLine("7. Remove Assignment by Name (for both List && Dictionary)");
            Console.WriteLine("8. Exit");

            Console.Write("\nChoose an option: ");
            int choice = Convert.ToInt16(Console.ReadLine());

                // =========================================
                // OPTION 1: CREATE COURSE ARRAY
                // =========================================
                if (choice == 1)
                {
                    Console.Write("\nHow many courses do you have? ");
                    int numberOfCourses = Convert.ToInt16(Console.ReadLine());

                    // Create the array
                    courses = new string[numberOfCourses];

                    // Add course names to the array
                    for (int i = 0; i < courses.Length; i++)
                    {
                        Console.Write("Enter course " + i + ": ");

                        courses[i] = Console.ReadLine();
                    }

                    // Display the array
                    Console.WriteLine("\nCourse Array:");

                    for (int i = 0; i < courses.Length; i++)
                    {
                        Console.WriteLine(i + ". " + courses[i]);
                    }
                }

                // =========================================
                // OPTION 2: UPDATE COURSE ARRAY
                // =========================================
                else if (choice == 2)
                {
                    if (courses.Length == 0)
                    {
                        Console.WriteLine("\nThe course array has not been created.");

                        Console.WriteLine("Please choose option 1 first.");
                    }
                    else
                    {
                        Console.WriteLine("\nCurrent Courses:");

                        for (int i = 0; i < courses.Length; i++)
                        {
                            Console.WriteLine( i + ". " + courses[i]);
                        }

                        Console.Write("\nEnter course index to update: ");
                        int courseIndex = Convert.ToInt16(Console.ReadLine());

                        if (courseIndex >= 0 && courseIndex < courses.Length)
                        {
                            Console.Write("Enter new course name: ");
                            courses[courseIndex] = Console.ReadLine();

                            Console.WriteLine("\nCourse updated!");

                            // Display updated array
                            Console.WriteLine("\nUpdated Courses:");

                            for (int i = 0; i < courses.Length; i++)
                            {
                                Console.WriteLine(i + ". " + courses[i]);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid course index.");
                        }
                    }
                }
                // =========================================
                // OPTION 3: ADD ASSIGNMENT TO LIST
                // =========================================
                else if (choice == 3)
                {
                    string addMore = "y";

                    // Display all assignments after the loop
                    Console.WriteLine("\nCurrent Assignments:");

                    if (assignments.Count == 0)
                    {
                        Console.WriteLine("No assignments found.");
                    }
                    else
                    {
                        for (int i = 0; i < assignments.Count; i++)
                        {
                            Console.WriteLine(i + ". " + assignments[i]);
                        }
                    }

                    while (addMore == "y")
                    {
                        Console.Write("\nEnter assignment name: ");
                        string newAssignment = Console.ReadLine();
                        assignments.Add(newAssignment);

                        Console.Write("\nWould you like to add another assignment? " +"(y/n): ");

                        addMore = Console.ReadLine().ToLower();
                    }

                    // Display all assignments after the loop
                    Console.WriteLine("\nCurrent Assignments:");

                    if (assignments.Count == 0)
                    {
                        Console.WriteLine("No assignments found.");
                    }
                    else
                    {
                        for (int i = 0; i < assignments.Count; i++)
                        {
                            Console.WriteLine(i + ". " + assignments[i]);
                        }
                    }
                }

                // =========================================
                // OPTION 4: UPDATE ASSIGNMENT
                // =========================================
                else if (choice == 4)
                {
                    Console.WriteLine("\nCurrent Assignments:");

                    if (assignments.Count == 0)
                    {
                        Console.WriteLine("No assignments found.");
                    }
                    else
                    {
                        for (int i = 0; i < assignments.Count; i++)
                        {
                            Console.WriteLine(i + ". " + assignments[i]);
                        }
                    }

                    Console.Write("\nEnter an assignment index to update: ");
                    int assignmentIndex = Convert.ToInt16(Console.ReadLine());

                    if (assignmentIndex >= 0 && assignmentIndex < assignments.Count)
                    {
                        string oldAssignment = assignments[assignmentIndex];

                        Console.Write("Enter updated assignment name: ");
                        string updatedAssignment = Console.ReadLine();
                        assignments[assignmentIndex] = updatedAssignment;
                        Console.WriteLine("Assignment updated!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid assignment index.");
                    }

                    // Display updated List
                    Console.WriteLine("\nUpdated Assignments:");

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine(i + ". " + assignments[i]);
                    }
                }

            // =========================================
            // OPTION 5: REMOVE BY INDEX FOR LIST
            // =========================================
            else if (choice == 5)
            {
                Console.WriteLine("\nCurrent Assignments:");

                for (int i = 0; i < assignments.Count; i++)
                {
                    Console.WriteLine(i + ". " + assignments[i]);
                }

                Console.Write("\nEnter assignment index to remove: ");
                int removeIndex = Convert.ToInt16(Console.ReadLine());

                if (removeIndex >= 0 && removeIndex < assignments.Count)
                {
                    assignments.RemoveAt(removeIndex);

                    Console.WriteLine("Assignment removed.");

                    Console.WriteLine("\nUpdated Assignments:");

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine(i + ". " + assignments[i]);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid assignment index.");
                }
            }

            // =========================================
            // OPTION 6: ADD OR UPDATE DICTIONARY DETAILS
            // =========================================
            else if (choice == 6)
                {
                    Console.WriteLine("\nCurrent Assignment Details:");

                    foreach (KeyValuePair<string, string> item in assignmentDetails)
                    {
                        Console.WriteLine("\nAssignment: " + item.Key);

                        Console.WriteLine("Details: " + item.Value);
                    }

                    Console.WriteLine("\nEnter assignment name (key): ");

                    string detailAssignment = Console.ReadLine();

                    Console.Write("Enter short description: ");

                    string description = Console.ReadLine();

                    Console.Write("Enter progress status: ");

                    string status = Console.ReadLine();

                    string details = description + " - " + status;

                    // Add or update Dictionary
                    assignmentDetails[detailAssignment] = details;

                    Console.WriteLine("\nAssignment details updated!");

                    // Always display updated Dictionary
                    Console.WriteLine("\nUpdated Assignment Details:");

                    foreach (KeyValuePair<string, string> item in assignmentDetails)
                    {
                        Console.WriteLine("\nAssignment: " + item.Key);

                        Console.WriteLine("Details: " + item.Value);
                    }
                }

                // =========================================
                // OPTION 7: REMOVE BY NAME FOR BOTH LIST AND DICTIONARY
                // =========================================
                else if (choice == 7)
                {
                    Console.WriteLine("\nCurrent Assignments:");

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine(i + ". " + assignments[i]);
                    }

                    Console.Write("\nEnter assignment name to remove: ");

                    string removeName = Console.ReadLine();

                    bool removed = assignments.Remove(removeName);

                    if (removed)
                    {
                        Console.WriteLine("Assignment removed from List.");
                    }
                    else
                    {
                        Console.WriteLine( "Assignment not found.");
                    }

                    Console.WriteLine("\nUpdated Assignments:");

                    for (int i = 0; i < assignments.Count; i++)
                    {
                        Console.WriteLine( i + ". " + assignments[i]);
                    }

                    // Ask about Dictionary
                    Console.Write("\nWould you also like to remove something from the Dictionary? (y/n): ");

                    string dictionaryChoice = Console.ReadLine().ToLower();

                    if (dictionaryChoice == "y")
                    {
                        Console.WriteLine("\nCurrent Assignment Details:");

                        foreach (KeyValuePair<string, string> item in assignmentDetails)
                        {
                            Console.WriteLine(item.Key + ": " + item.Value);
                        }

                        Console.Write("\nEnter assignment name/key to remove: ");

                        string keyToRemove = Console.ReadLine();

                        if (assignmentDetails.Remove(keyToRemove))
                        {
                            Console.WriteLine("Dictionary entry removed.");
                        }
                        else
                        {
                            Console.WriteLine("Dictionary key not found.");
                        }

                        Console.WriteLine("\nUpdated Assignment Details:");

                        foreach (KeyValuePair<string, string> item in assignmentDetails)
                        {
                            Console.WriteLine(item.Key + ": " + item.Value);
                        }
                    }
                }
                // =========================================
                // OPTION 8: EXIT
                // =========================================
                else if (choice == 8)
                {
                    Console.WriteLine("\nGood work!");
                    running = false;
                }

                // =========================================
                // Invalid option
                // ========================================
                else
                {
                    Console.WriteLine("\nInvalid option. Choose 1-8.");
                }
        }
    }
}
