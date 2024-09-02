#include <stdio.h>
#include <string.h>

#define MAX_ROUTES 5
#define MAX_DRIVERS 5

internal class Program
{
    private static void Main(string[] args)
    {
        typedef Driver;

        typedef Route;

        void initializeRoutes(Route routes[], int size)
        {
            for (int i = 0; i < size; i++)
            {
                routes[i].isAssigned = 0; // No driver assigned initially
            }
        }

        void displayRoutes(Route routes[], int size)
        {
            printf("\nAvailable Routes:\n");
            for (int i = 0; i < size; i++)
            {
                printf("%d. %s\n", i + 1, routes[i].routeName);
            }
        }

        void displayDrivers(Driver drivers[], int size)
        {
            printf("\nAvailable Drivers:\n");
            for (int i = 0; i < size; i++)
            {
                printf("%d. %s (Age: %d, License: %s)\n", i + 1, drivers[i].name, drivers[i].age, drivers[i].license);
            }
        }

        void assignDriverToRoute(Route routes[], Driver drivers[], int routeIndex, int driverIndex)
        {
            routes[routeIndex].assignedDriver = drivers[driverIndex];
            routes[routeIndex].isAssigned = 1;
            printf("\nDriver %s has been assigned to route %s\n", drivers[driverIndex].name, routes[routeIndex].routeName);
        }

        int main()
        {
            Route routes[MAX_ROUTES] = {
        {"Route 1: Downtown to Uptown", {"", 0, ""}, 0},
        {"Route 2: Eastside to Westside", {"", 0, ""}, 0},
        {"Route 3: Northside to Southside", {"", 0, ""}, 0},
        {"Route 4: Airport to City Center", {"", 0, ""}, 0},
        {"Route 5: Suburbs to Downtown", {"", 0, ""}, 0}
    };

            Driver drivers[MAX_DRIVERS] = {
        {"John Doe", 45, "AB12345"},
        {"Jane Smith", 39, "CD67890"},
        {"Jim Brown", 50, "EF11223"},
        {"Anna White", 33, "GH44556"},
        {"Tom Black", 48, "IJ78901"}
    };

            initializeRoutes(routes, MAX_ROUTES);

            int routeChoice, driverChoice;

            while (1)
            {
                displayRoutes(routes, MAX_ROUTES);
                printf("\nSelect a route by number (0 to exit): ");
                scanf("%d", &routeChoice);

                if (routeChoice == 0)
                {
                    break;
                }

                displayDrivers(drivers, MAX_DRIVERS);
                printf("\nSelect a driver by number: ");
                scanf("%d", &driverChoice);

                if (routeChoice > 0 && routeChoice <= MAX_ROUTES && driverChoice > 0 && driverChoice <= MAX_DRIVERS)
                {
                    assignDriverToRoute(routes, drivers, routeChoice - 1, driverChoice - 1);
                }
                else
                {
                    printf("\nInvalid choice. Please try again.\n");
                }
            }

            printf("\nProgram terminated.\n");
            return 0;
        }
    }
}

struct {
    char name[50];
    int age;
    char license[20];
}

struct {
    char routeName[50];
    Driver assignedDriver;
    int isAssigned;
}