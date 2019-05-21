using Xunit;

namespace Vehicle.UnitTests
{
    public class car
    {
        [Fact]
        public void car_can_start()
        {
            // arrange
            var subject = new Car();

            // act
            subject.Start();

            // assert
            Assert.True(subject.Started, "Car hasn't started");
        }

        [Fact]
        public void car_can_stop()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }

        [Fact]
        public void car_cannot_move_forward_if_not_started()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }

        [Theory]
        [InlineData(4, 4)]
        // TODO: More data to be added
        public void car_can_move_forward_and_consumes_petrol(int timesToMoveForward, int expectedPetrolLitresConsumed)
        {
            // arrange
            var subject = new Car();
            subject.Start();

            // act
            while (timesToMoveForward > 0)
            {
                subject.MoveForward();
                timesToMoveForward--;
            }

            // assert
            Assert.Equal(expectedPetrolLitresConsumed, subject.PetrolLitresConsumed);
        }
        [Theory]
        [InlineData(4, 4)]
        public void car_can_move_forward_and_consumes_lesspetrol(int timesToMoveForward, int expectedPetrolLitresConsumed)
        {
            // arrange
            var subject = new Car();
            subject.Start();

            // act
            while (timesToMoveForward > 0)
            {
                subject.MoveForward();
                timesToMoveForward--;
            }

            // assert
            Assert.Equal(expectedPetrolLitresConsumed, subject.PetrolLitresConsumed);
        }
        [Fact]
        public void car_can_move()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }
        [Fact]
        public void car_has_steering()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }
        [Fact]
        public void car_has_4wheels_forachange()
        {
            // TODO: arrange
            // TODO: act
            // TODO: assert
        }
    }
}
