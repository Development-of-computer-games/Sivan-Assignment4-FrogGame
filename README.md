# Sivan-Assignment4-FrogGame

### Frog game - There are 3 courses, Each of them has random cars which appears and moving to left \ right diection. The user goal is to move the frog safely to the other side and face the obstacle along the way. When the frog hits the car, they both vanish, and the game is over. When the frog passes safely, there is "Winner!" text that appears.
### Movement - Arrow keys, (Up, Down, Left, Right)

# The game :
![frog](https://user-images.githubusercontent.com/57447482/140742789-6eb34235-440c-4dfc-abbc-54dbc77dba6e.png)
 # Winner message : 
![winner](https://user-images.githubusercontent.com/57447482/140742833-8b89d2c0-6f49-4e99-87d5-e805996c1be6.png)

### Little about the code :
1. For each of the cars I created a spawner. To that spawner i connected the script for the cars appearing. The main prefab object has the collision, rigidbody, and the neccessary entities in order to catch collision and movement.
2. The finish line is defined by "Box collidor" , once the user collides with it, the winner text trigger is appear.
3. The frog has "Box collidor" as well, in order to catch hits from the cars and has all the entities needed for movement.
4. The cars are seperated to : Left to right moving cars & Right to left moving cars. Each of them has seperate mover because they need to move in spesific direction.
