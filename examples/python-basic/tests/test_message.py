from app.message import get_message


def test_get_message() -> None:
    assert get_message() == "Enterprise GitHub Actions"