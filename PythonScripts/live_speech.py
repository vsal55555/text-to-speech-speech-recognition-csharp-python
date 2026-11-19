import whisper
import sounddevice as sd
from scipy.io.wavfile import write
import sys

sys.stdout.reconfigure(encoding='utf-8')
sys.stderr.reconfigure(encoding='utf-8')

SAMPLE_RATE = 16000
DURATION = 5

print("Listening...")
print("Speak now...")

audio = sd.rec(
    int(DURATION * SAMPLE_RATE),
    samplerate=SAMPLE_RATE,
    channels=1,
    dtype='int16'
)

sd.wait()

write(
    "test_recording.wav",
    SAMPLE_RATE,
    audio
)

print("Recording saved.")

model = whisper.load_model("tiny")

try:

    result = model.transcribe(
        "test_recording.wav"
    )

    print("RESULT_START")
    print(result["text"])

except Exception as ex:

    print("ERROR_START")
    print(str(ex))