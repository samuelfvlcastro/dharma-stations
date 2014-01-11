var flickerSpeed : float = 1.00;

private var randomizer : int = 0;

while (true)
{
if (randomizer == 0)
{
light.enabled = false;
}
else
light.enabled = true;
randomizer = Random.Range (0.1, 3.5);



yield WaitForSeconds (flickerSpeed);

}