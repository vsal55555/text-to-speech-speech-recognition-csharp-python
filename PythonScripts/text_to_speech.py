from gtts import gTTS
import sys

file_path = sys.argv[1]
language = sys.argv[2]

lang_map = {
    "English": "en",
    "Nepali": "ne",
    "Japanese": "ja",
    "Hindi": "hi"
}

with open(file_path, "r", encoding="utf-8") as file:
    text = file.read()

tts = gTTS(
    text=text,
    lang=lang_map[language]
)

tts.save("speech.mp3")

print("SUCCESS")