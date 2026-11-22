# MG7
## Devlog
The TreeOfBirds script is attached to the tree object. It uses an array to store all of the sparrows in the scene. In the Update method, the script loops through the array and checks the distance between the player and the tree. Vectors are used to get the positions of the player and tree, and calculate the distance with Vector3.Distance(). If the player is within the interaction distance, the script sets that bird to active so it can appear from the tree.

## Open-Source Assets
- [Forest Nature Pack](https://kaylousberg.itch.io/kaykit-forest) - environment 3D models
- [Quirky Series](https://assetstore.unity.com/packages/3d/characters/animals/quirky-series-free-animals-pack-178235) - animal 3D models
