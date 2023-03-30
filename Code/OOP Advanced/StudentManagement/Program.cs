using StudentManagement;
bool running = true;
School greenwich = new School();
while (running)
{
    greenwich.PrinMenu();
    int choice = greenwich.GetChoice();
    greenwich.Process(choice);
    running = (choice != 0);


}
