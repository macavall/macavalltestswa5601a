async function loadTimestamp() {
    const el = document.getElementById("timestamp");
    el.textContent = "Loading\u2026";

    try {
        const response = await fetch("/api/timestamp");
        if (!response.ok) {
            throw new Error(`Request failed with status ${response.status}`);
        }
        const data = await response.json();
        const date = new Date(data.timestamp);
        el.textContent = date.toLocaleString();
    } catch (err) {
        el.textContent = "Unable to load timestamp";
        console.error(err);
    }
}

document.getElementById("refresh").addEventListener("click", loadTimestamp);
document.addEventListener("DOMContentLoaded", loadTimestamp);
