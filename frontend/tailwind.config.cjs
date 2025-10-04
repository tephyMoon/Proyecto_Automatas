/** @type {import('tailwindcss').Config} */
module.exports = {
  darkMode: 'class',
  content: [
    './components/**/*.{vue,js,ts}',
    './layouts/**/*.{vue,js,ts}',
    './pages/**/*.{vue,js,ts}',
    './app.{vue,js,ts}',
    './plugins/**/*.{js,ts}'
  ],
  theme: {
    extend: {
      colors: {
        background: '#000000',
        text: '#ffffff',
        primary: '#212121',
        secondary: '#169875',
        accent: '#1dcd9e'
      },
      fontFamily: {
        montserrat: ['Montserrat', 'ui-sans-serif', 'system-ui']
      },
      borderRadius: {
        '2xl': '1rem'
      }
    }
  },
  plugins: []
}
