using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TrackSelection : MonoBehaviour
{
    public List<TrackInfo> tracks; // List of available tracks
    public Button[] trackButtons; // Array of UI buttons for track selection
    public Text selectedTracksText; // Text to display selected tracks

    private List<TrackInfo> selectedTracks = new List<TrackInfo>(); // List to hold selected tracks

    void Start()
    {
        // Initialize track buttons
        for (int i = 0; i < trackButtons.Length; i++)
        {
            int index = i; // Required to avoid closure issues
            trackButtons[i].onClick.AddListener(() => SelectTrack(index));
        }

        UpdateSelectedTracksText();
    }

    // Method to handle track selection
    void SelectTrack(int index)
    {
        TrackInfo selectedTrack = tracks[index];

        // Check if the track is already selected
        if (!selectedTracks.Contains(selectedTrack))
        {
            // Add track to selected tracks list
            selectedTracks.Add(selectedTrack);
            UpdateSelectedTracksText();
        }
        else
        {
            // Deselect track if already selected
            selectedTracks.Remove(selectedTrack);
            UpdateSelectedTracksText();
        }
    }

    // Update the UI text with selected tracks
    void UpdateSelectedTracksText()
    {
        string text = "Selected Tracks:\n";

        // Build text with selected tracks
        foreach (var track in selectedTracks)
        {
            text += "- " + track.trackName + "\n";
        }

        // Update the UI text
        selectedTracksText.text = text;
    }
}

// Class to hold information about a track
[System.Serializable]
public class TrackInfo
{
    public string trackName; // Name of the track
    public int trackID; // Unique identifier for the track
    // Add any other relevant information about the track
}
