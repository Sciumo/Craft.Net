using Craft.Net.Data.Blocks;
namespace Craft.Net.Data.Items
{
    
    public class BrewingStandItem : Item
    {
        public override ushort Id
        {
            get
            {
                return 379;
            }
        }

        public override void OnItemUsed(Vector3 clickedBlock, Vector3 clickedSide, Vector3 cursorPosition, World world, Entities.Entity usedBy)
        {
            if (world.GetBlock(clickedBlock + clickedSide) == 0)
                world.SetBlock(clickedBlock + clickedSide, new BrewingStandBlock());
        }
    }
}
