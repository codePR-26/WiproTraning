/** @type {import('tailwindcss').Config} */
module.exports = {
  content: [
    "./src/**/*.{html,ts}",
  ],
  darkMode: ['selector', '[data-theme="dark"]'],
  theme: {
    extend: {
      colors: {
        teal: {
          DEFAULT: '#0d4f4f',
          2: '#1a7a7a',
          3: '#4ecdc4',
          subtle: 'rgba(78,205,196,0.1)',
        },
        gold: '#e6a817',
        'text-primary': 'var(--text-primary)',
        'text-secondary': 'var(--text-secondary)',
        'text-muted': 'var(--text-muted)',
        surface: 'var(--surface)',
        'surface-2': 'var(--surface2)',
        bg: 'var(--bg)',
        'card-bg': 'var(--card-bg)',
        border: 'var(--border)',
      },
      fontFamily: {
        serif: ['"Playfair Display"', 'serif'],
        sans: ['"DM Sans"', 'sans-serif'],
      },
      boxShadow: {
        sm: '0 2px 8px rgba(13,79,79,0.08)',
        md: '0 4px 20px rgba(13,79,79,0.12)',
        lg: '0 8px 40px rgba(13,79,79,0.16)',
      },
      borderRadius: {
        xl: '14px',
        '2xl': '16px',
      },
    },
  },
  plugins: [],
}
