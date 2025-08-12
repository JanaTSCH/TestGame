using Godot;

namespace Game.UI;

public partial class GameUI : MarginContainer
{
	[Signal]
	public delegate void PlaceTowerButtonPressedEventHandler();
	[Signal]
	public delegate void PlaceVillageButtonPressedEventHandler();

	private Button PlaceTowerButton;
	private Button PlaceVillageButton;

	public override void _Ready()
	{
		PlaceTowerButton = GetNode<Button>("%PlaceTowerButton");
		PlaceVillageButton = GetNode<Button>("%PlaceVillageButton");

		PlaceTowerButton.Pressed += OnPlaceTowerButtonPressed;
		PlaceVillageButton.Pressed += OnPlaceVillageButtonPressed;
	}

	private void OnPlaceTowerButtonPressed()
	{
		EmitSignal(SignalName.PlaceTowerButtonPressed);
	}

	private void OnPlaceVillageButtonPressed()
	{
		EmitSignal(SignalName.PlaceVillageButtonPressed);
	}
}
