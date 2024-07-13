/** @type {import('tailwindcss').Config} */
export default {
  content: ['./index.html', './src/**/*.{js,jsx,ts,tsx}'],
  theme: {
    extend: {
      fontFamily: {
        sueEllen: ['"Sue Ellen Francisco"', 'cursive'],
        montserrat: ['Montserrat', 'sans-serif'],
      },
      colors: {
        customGreen: '#588c7e',
        burntOrange: '#F2762e',
        lightOrange: '#F2913d',
        dustyPink: '#BF8C80',
        backgroundWhite: '#F2F2F2',
      },
    },
  },
  plugins: [],
}
