package com.example;

public final class App {

    private App() {
    }

    public static String message() {
        return "Enterprise GitHub Actions";
    }

    public static void main(String[] args) {
        System.out.println(message());
    }
}