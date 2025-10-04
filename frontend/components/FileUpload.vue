<script setup lang="ts">
/**
 * Componente de subida de archivos .txt (solo maquetado).
 * 🔌 Integración futura:
 *  - Reemplazar el emit con llamada a API si desean subir al backend.
 */
const emit = defineEmits<{
  (e: 'file:selected', text: string): void
}>()

const onFile = async (e: Event) => {
  const input = e.target as HTMLInputElement
  const file = input.files?.[0]
  if (!file) return
  const text = await file.text()
  emit('file:selected', text)
}
</script>

<template>
  <div class="p-4 border border-primary rounded-2xl bg-primary/20">
    <label class="block text-sm mb-2">Subir archivo .txt</label>
    <input type="file" accept=".txt" @change="onFile"
           class="block w-full rounded-lg bg-primary/50 border border-primary px-3 py-2" />
  </div>
</template>
